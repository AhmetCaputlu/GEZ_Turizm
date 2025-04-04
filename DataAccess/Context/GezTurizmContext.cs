using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.Entities.Models.Countries;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class GezTurizmContext : IdentityDbContext<WebUserAccount, IdentityRole<int>, int>
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
        public DbSet<PartnerCompanyTransaction> PartnerCompanyTransactions { get; set; }
        public DbSet<PassEventTicket> PassEventTickets { get; set; }
        public DbSet<PassTourTicket> PassTourTickets { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<SubContractWorkerSupplier> SubContractWorkerSuppliers { get; set; }
        public DbSet<RentalVehicleSupplier> RentalVehicleSuppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<ProductOrderDetail> ProductOrderDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<TourTicket> TourTickets { get; set; }
        public DbSet<EventTicket> EventTickets { get; set; }
        public DbSet<TourTicketOrder> TourTicketOrders { get; set; }
        public DbSet<EventTicketOrder> EventTicketOrders { get; set; }
        public DbSet<EventTicketOrderDetail> EventTicketOrderDetails { get; set; }
        public DbSet<TourTicketOrderDetail> TourTicketOrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .EnableSensitiveDataLogging()
                    .UseSqlServer(Environment.GetEnvironmentVariable("Connection_String"));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GezTurizmContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

//todo:BLL katmanında HttpContext nesnesi ile created ip ve updated ip bilgileri alınacak.
//todo:BLL katmanında kullanıcının mail bilgisi order içerisine yazılacak(webuseremail).Örnek verilerde şimdilik rastgele
//todo:BLL katmanında ürünün ve biletlerin fiyatları,ilgili ürünün fiyatına göre order detail içerisine yazılacak.Örnek verilerde şimdilik rastgele
//todo:BLL katmanında transaction işlemleri alınan ve satılan biletler doğrultusunda yönlendirilecek.Örnek verilerde durum rastgele
//todo:IsUpdated ve diğer güncelleme property'leri BLL katmanında atanacak.(Ip Adress ve diğer değerler)

