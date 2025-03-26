using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Employees
{
    internal class EmployeeConfiguration:BaseEmployeeModelConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
           
            builder.Property(x => x.CurrentPosition).IsRequired(true).HasConversion(x => x.ToString(), x => (Department)Enum.Parse(typeof(Department), x)).HasMaxLength(35);
            builder.Property(x => x.DaysWorked).IsRequired(false);
            //Mapping

            //Residence Region
            builder.HasOne(x => x.ResidenceRegion).WithMany(x => x.Employees).HasForeignKey(x => x.ResidenceRegionId).OnDelete(DeleteBehavior.NoAction);
            //Country
            builder.HasOne(x => x.Country).WithMany(x => x.Employees).HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}



