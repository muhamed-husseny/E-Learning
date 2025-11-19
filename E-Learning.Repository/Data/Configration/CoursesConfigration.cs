using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Repository.Data.Configration
{
    internal class CoursesConfigration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(C => C.Title)
                .HasMaxLength(50);
            builder.Property(C => C.Description)
                .HasMaxLength(150);

            builder.HasMany(C => C.Modules)
                .WithOne(M => M.Course)
                .HasForeignKey(M => M.CourseId);
        }
    }
}
