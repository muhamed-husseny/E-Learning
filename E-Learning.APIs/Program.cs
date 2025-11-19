#region Configure Service
using E_Learning.Repository.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies();
});
#endregion


var app = builder.Build();

#region Update_DataBase and DataSeeding

using var Scoped = app.Services.CreateScope();
var Services = Scoped.ServiceProvider;
var _Dbcontext = Services.GetRequiredService<StoreContext>();
//var _IdentityDbcontext = Services.GetRequiredService<AppIdentityDbContext>();

try
{
    await _Dbcontext.Database.MigrateAsync();

    //await StoreContextSeed.SeedAsync(_Dbcontext);
    // await _IdentityDbcontext.Database.MigrateAsync();
    // var _UserManger = Services.GetRequiredService<UserManager<AppUser>>();
    // await AppIdentityDbContextSeed.SeedUsersAsync(_UserManger);
}
catch (Exception ex)
{

    var logger = Services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred while migrating or seeding the database.");
}

    #endregion

#region Configure Kestrel Middlewares
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 
#endregion

app.Run();

