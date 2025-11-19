using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Repository.Data.Configration
{
    internal class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(S => S.FirstName)
                .HasMaxLength(15);
            builder.Property(S => S.LastName)
                .HasMaxLength(15);

            builder.HasMany(S => S.Courses)
                .WithMany(C => C.Students);
               
        }
    }
}
