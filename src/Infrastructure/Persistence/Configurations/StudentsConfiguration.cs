using clen_code_project.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace clen_code_project.Infrastructure.Persistence.Configurations
{
    public class StudentsConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.Property(s => s.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(s => s.Email)
               .HasMaxLength(200)
               .IsRequired();


            builder.Property(s => s.Password)
                           .HasMaxLength(200)
                           .IsRequired();
        }
    }
}