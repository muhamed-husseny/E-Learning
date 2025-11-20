namespace E_Learning.Repository.Data.Configration
{
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Name)
                .HasMaxLength(50);
            builder.Property(I => I.Bio)
                .HasMaxLength(500);

            builder.HasMany(I => I.Courses)
                .WithOne(C => C.Instructor)
                .HasForeignKey(C => C.InstructorId);
        }
    }
}
