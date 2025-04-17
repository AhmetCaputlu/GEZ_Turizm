using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Employees
{
    internal class ContractEmployeeConfiguration : BaseModelConfiguration<ContractEmployee>
    {
        public override void Configure(EntityTypeBuilder<ContractEmployee> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.DriverLicense).IsRequired(false).HasDefaultValue(DriverLicense.None).HasConversion(x => x.ToString(), x => (DriverLicense)Enum.Parse(typeof(DriverLicense), x));
            builder.Property(x => x.Language).IsRequired(false).HasDefaultValue(Language.None).HasConversion(x => x.ToString(), x => (Language)Enum.Parse(typeof(Language), x));

            builder.HasData(ContractEmployeeSeedData.GetContractEmployees(5));
        }
    }
}
