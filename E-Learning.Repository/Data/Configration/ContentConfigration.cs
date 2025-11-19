using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Repository.Data.Configration
{
    internal class ContentConfigration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.Property(C => C.Title)
                .HasMaxLength(50);
            builder.Property(C => C.Content_Type)
                .HasMaxLength(10);

            
        }
    }
}
