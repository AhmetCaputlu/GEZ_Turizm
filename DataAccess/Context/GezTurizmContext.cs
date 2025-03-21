using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class GezTurizmContext : IdentityDbContext<WebUserAccount,IdentityRole<int>,int>
    {
        public GezTurizmContext()
        {

        }
        public GezTurizmContext(DbContextOptions<GezTurizmContext> options) : base(options)
        {

        }

        public DbSet<WebUserAccount> AspNetUsers { get; set; }
        public DbSet<WebUserProfile> AspNetUserProfiles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ContractDriver> ContractDrivers { get; set; }
        public DbSet<ContractTourGuide> ContractTourGuides { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<RentalVehicle> RentalVehicles { get; set; }
        public DbSet<ContractDriver_Vehicle> ContractDrivers_Vehicles { get; set; }
        public DbSet<ContractDriver_RentalVehicle> ContractDrivers_RentalVehicles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ServiceRegion> ServiceRegions { get; set; }
        public DbSet<ResidenceRegion> ResidenceRegions { get; set; }
        public DbSet<ContractTourGuide_ServiceRegion> ContractTourGuides_ServiceRegions { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<PartnerCompany> PartnerCompanies { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<SubContractWorkerSupplier> SubContractWorkerSuppliers { get; set; }
        public DbSet<RentalVehicleSupplier> RentalVehicleSuppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }


       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Server=.\\SQLEXPRESS;Database=GEZTurizmDB;Integrated Security=True;TrustServerCertificate=true;");}
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GezTurizmContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
