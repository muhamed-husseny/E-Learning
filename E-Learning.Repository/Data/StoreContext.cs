namespace E_Learning.Repository.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreContext).Assembly);
        }
       
        public DbSet<Course> courses { get; set; }

        public DbSet<Module> modules { get; set; }

        public DbSet<Lesson> lessons { get; set; }

        public DbSet<Content> contents { get; set; }

        public DbSet<Instructor> instructors { get; set; }

        public DbSet<Student> students { get; set; }

    }  
}
