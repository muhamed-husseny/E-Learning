namespace E_Learning.Repository.Data.Configration
{
    internal class LessonConfigration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.Property(L => L.Title)
                .HasMaxLength(50);

            builder.HasMany(L => L.Contents)
                .WithOne(C => C.Lesson)
                .HasForeignKey(C => C.LessonId);
        }
    }
}
