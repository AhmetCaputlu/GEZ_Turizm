﻿using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Orders;
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
        public GezTurizmContext(DbContextOptions<GezTurizmContext> options) : base(options)
        {

        }

        public DbSet<WebUserAccount> AspNetUsers { get; set; }
        public DbSet<WebUserProfile> AspNetUserProfiles { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<PartnerCompany> PartnerCompanies { get; set; }
        public DbSet<PartnerCompanyTransaction> PartnerCompanyTransactions { get; set; }
        public DbSet<RentalVehicleSupplier> RentalVehicleSuppliers { get; set; }
        public DbSet<SubContractWorkerSupplier> SubContractWorkerSuppliers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ContractEmployee> ContractEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ActivityTicketOrderDetail> ActivityTicketOrderDetails { get; set; }
        public DbSet<ActivityTicketOrder> ActivityTicketOrders { get; set; }
        public DbSet<ActivityPassTicket> ActivityPassTickets { get; set; }
        public DbSet<ServiceRegion> ServiceRegions { get; set; }
        public DbSet<ActivityTicket> ActivityTickets { get; set; }
        public DbSet<RentalVehicle> RentalVehicles { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GezTurizmContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

//todo:BLL katmanında kullanıcının mail bilgisi order içerisine yazılacak(webuseremail).Örnek verilerde şimdilik rastgele
//todo:BLL katmanında ürünün ve biletlerin fiyatları,ilgili ürünün fiyatına göre order detail içerisine yazılacak.Örnek verilerde şimdilik rastgele
//todo:BLL katmanında transaction işlemleri alınan ve satılan biletler doğrultusunda yönlendirilecek.Örnek verilerde durum rastgele

//todo: RequestDTO'lar içerisinde bulunan Navigation Id'leri doldurulacak. İş mantığında Id bilgisi ile veritabanı araması yapılacak.

//todo: Employee bilgilerinde hiredate Request DTO lar için datetime.now atanacak ??RequestDTo içerisinde bu özellik olmicak
//todo: Claimlar kullanılarak kullanıcının Guid bilgisi ile int ID bilgisi de tutulacak!!