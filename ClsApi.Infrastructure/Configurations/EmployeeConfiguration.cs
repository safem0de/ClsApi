

using ClsApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClsApi.Infrastructure.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpNo);
            
            builder.Property(f => f.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(l => l.LastName)    
                    .IsRequired()
                    .HasMaxLength(50);
                    
            builder.ToTable("Employees");
        }
    }
}