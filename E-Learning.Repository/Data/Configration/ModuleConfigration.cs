namespace E_Learning.Repository.Data.Configration
{
    internal class ModuleConfigration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.Property(M => M.Title)
                .HasMaxLength(50);
            builder.Property(M => M.Description)
                .HasMaxLength(150);

            builder.HasMany(M => M.Lessons)
                .WithOne(L => L.Module)
                .HasForeignKey(L => L.ModuleId);
        }
    }
}
