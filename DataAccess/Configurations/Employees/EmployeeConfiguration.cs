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
           
            builder.Property(x => x.CurrentPosition).IsRequired(true).HasConversion(x => x.ToString(), x => (Department)Enum.Parse(typeof(Department), x));
            builder.Property(x => x.CurrentPosition).HasMaxLength(35);
            builder.Property(x => x.CurrentPosition).HasMaxLength(50);
            //Mapping

            //Residence Region
            builder.HasOne(x => x.ResidenceRegion).WithMany(x => x.Employees).HasForeignKey(x => x.ResidenceRegionId).OnDelete(DeleteBehavior.NoAction);
            //EventTicketOrder
            builder.HasMany(x => x.EventTicketOrders).WithOne(x => x.Employee).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            //ProductOrder
            builder.HasMany(x => x.ProductOrders).WithOne(x => x.Employee).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
            //TourTicketOrder
            builder.HasMany(x => x.TourTicketOrders).WithOne(x => x.Employee).HasForeignKey(x => x.EmployeeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}



