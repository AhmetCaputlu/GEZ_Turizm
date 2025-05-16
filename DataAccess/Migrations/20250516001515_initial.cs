using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CountryDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CountryPhone = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fba8120b-fd74-4d81-b58f-07c68d007968"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 950, DateTimeKind.Local).AddTicks(1781)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0c49896d-ae04-4b61-a70c-c8cdebff95ac"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartnerCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptTickets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "54598841-3538-4539-89d7-ad3ecff1c764"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 941, DateTimeKind.Local).AddTicks(7717)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8ddc1671-90fc-431c-9da0-118f8403d514"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    CompanyName = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalVehicleSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c09d4a16-5fd7-44c7-9c32-4b1a42923814"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 947, DateTimeKind.Local).AddTicks(1784)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3a385473-9a07-4fb4-904f-1906c959c5e1"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    CompanyName = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalVehicleSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    TransportVehicle = table.Column<int>(type: "int", nullable: false),
                    TouristPopulation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasHotelFacility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a19be872-ee98-42ba-9697-6c89caf97e35"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 961, DateTimeKind.Local).AddTicks(6525)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4aaadc2d-58e3-40cb-96ad-8e931e8f9147"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubContractWorkerSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b1552cf8-26c7-4e44-9bdf-f52eb27950ad"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 948, DateTimeKind.Local).AddTicks(6633)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "016b2f1a-f4b5-4dfe-b71e-7d342c12687f"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    CompanyName = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractWorkerSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 975, DateTimeKind.Local).AddTicks(7463)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "IP verilmedi"),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractCount = table.Column<int>(type: "int", nullable: true),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaysWorked = table.Column<int>(type: "int", nullable: true),
                    CurrentPosition = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "92e8f0b9-105a-432f-ae37-0514f76ece4f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 952, DateTimeKind.Local).AddTicks(6995)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "def3233b-3d49-43e2-b030-5fd61b0d360f"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PartnerCompanyTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PartnerCompanyId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "faa89186-8e1d-4e0d-984d-d1c1c28a6cd8"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 943, DateTimeKind.Local).AddTicks(2650)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0fa7f551-077e-40a1-8f08-c04580f30ba1"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerCompanyTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartnerCompanyTransactions_PartnerCompanies_PartnerCompanyId",
                        column: x => x.PartnerCompanyId,
                        principalTable: "PartnerCompanies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ActivityCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6f3ac5db-30e3-497c-8173-e87ab56f8559"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 940, DateTimeKind.Local).AddTicks(3026)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6405741c-3afb-4584-8aa6-2808de4dd51e"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_ServiceRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "ServiceRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverLicense = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "None"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "None"),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "53afeadd-a546-4088-87a2-0e906c061e3e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 951, DateTimeKind.Local).AddTicks(4402)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e32aff2e-28a6-4625-bdf9-dfb02a78ae3d"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractEmployees_SubContractWorkerSuppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "SubContractWorkerSuppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserProfiles",
                columns: table => new
                {
                    WebUserAccountId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 15, 602, DateTimeKind.Local).AddTicks(5315)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "IP verilmedi"),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserProfiles", x => x.WebUserAccountId);
                    table.ForeignKey(
                        name: "FK_AspNetUserProfiles_AspNetUsers_WebUserAccountId",
                        column: x => x.WebUserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityTicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    WebUserEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    WebUserAccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "db619b49-c1c2-457f-a1ad-a32bb3c9da32"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 958, DateTimeKind.Local).AddTicks(6219)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "96239f8a-0dac-4c6d-8aca-3aa4181a4c57"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTicketOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityTicketOrders_AspNetUsers_WebUserAccountId",
                        column: x => x.WebUserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivityTicketOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityPassTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CommissionRate = table.Column<byte>(type: "tinyint", nullable: false),
                    TotalCostwithCommission = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    PartnerCompanyTransactionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0893f6b4-300a-42d5-bff9-1c74be26353f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 960, DateTimeKind.Local).AddTicks(69)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1720b87f-a77f-4063-bdb6-268fe43c1862"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPassTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityPassTickets_PartnerCompanyTransactions_PartnerCompanyTransactionId",
                        column: x => x.PartnerCompanyTransactionId,
                        principalTable: "PartnerCompanyTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketHolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DepartureAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DestinationAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: true),
                    NetCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b9e8d76c-e598-4222-810a-dbf3bb6ca513"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 963, DateTimeKind.Local).AddTicks(1092)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "32182389-93ce-47aa-81a4-c7881da2eedc"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityTickets_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RentalVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyRentalFee = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalRentalDay = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    RentalVehicleSupplierId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9d73326f-f457-447d-a145-17df83322788"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 971, DateTimeKind.Local).AddTicks(6683)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0aaa7119-2b23-427f-ba2f-f0c2f80af1e3"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    VehicleType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Kilometer = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Capacity = table.Column<short>(type: "smallint", maxLength: 2, nullable: false),
                    IsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalVehicles_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentalVehicles_RentalVehicleSuppliers_RentalVehicleSupplierId",
                        column: x => x.RentalVehicleSupplierId,
                        principalTable: "RentalVehicleSuppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarketValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8025f371-2f3a-4869-9b9d-a29de8105ffe"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 973, DateTimeKind.Local).AddTicks(2001)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e617b3fd-960d-4574-9eef-4feacf2166e3"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    VehicleType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Kilometer = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Capacity = table.Column<short>(type: "smallint", maxLength: 2, nullable: false),
                    IsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityTicketOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    ActivityTicketId = table.Column<int>(type: "int", nullable: true),
                    ActivityTicketOrderId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "aff252dd-95eb-43b6-b9be-5ca98e22ec77"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 16, 3, 15, 14, 957, DateTimeKind.Local).AddTicks(2095)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "be0cf1f5-baac-4882-86b7-240066c08c3e"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTicketOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityTicketOrderDetails_ActivityTicketOrders_ActivityTicketOrderId",
                        column: x => x.ActivityTicketOrderId,
                        principalTable: "ActivityTicketOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivityTicketOrderDetails_ActivityTickets_ActivityTicketId",
                        column: x => x.ActivityTicketId,
                        principalTable: "ActivityTickets",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "SouthAmerica", "TR", "Excepturi fugiat molestiae voluptas ut perferendis.", "Turkey", "+90", new DateTime(2014, 9, 26, 10, 16, 12, 0, DateTimeKind.Unspecified), "01a48e92-48eb-42c4-8754-1227b2b5359d", "230.121.200.170", "14a5d4a0-807d-40f8-9c90-395f48b8203f", "No", "Passive", null, null, null },
                    { 2, "Australia", "RU", "Rerum placeat sint odit et voluptatem.", "Russia", "+7", new DateTime(2005, 7, 2, 12, 36, 52, 0, DateTimeKind.Unspecified), "5ac423f0-c458-4cbc-9a66-06109ccffafe", "240.173.15.150", "dcae8653-4ece-42ea-b621-a0935b8e44ad", "No", "Active", null, null, null },
                    { 3, "None", "USA", "Sunt aut non est enim est.", "United States of America", "+1", new DateTime(2011, 5, 10, 21, 26, 10, 0, DateTimeKind.Unspecified), "f7725082-59e3-45e8-9544-6c2ae7379a02", "144.140.233.46", "ae4b7f2c-5c9f-4c4a-b9b5-6e0241f85246", "No", "Active", null, null, null },
                    { 4, "Australia", "SA", "Reiciendis velit occaecati aliquam molestiae ea.", "Kingdom of Saudi Arabia", "+966", new DateTime(2016, 11, 6, 11, 38, 45, 0, DateTimeKind.Unspecified), "18cfd02e-2ed3-419a-bb6a-4e26c4d34d9d", "101.198.125.25", "fb06dc59-6194-40e5-b730-2b0ba8b70160", "No", "Passive", null, null, null },
                    { 5, "Europe", "GER", "Ratione aut voluptate qui quos suscipit.", "Germany", "+49", new DateTime(2014, 1, 4, 10, 25, 35, 0, DateTimeKind.Unspecified), "1356f891-d508-47f2-a76f-d15327abb17c", "150.25.226.29", "71ebf0f5-d825-4f69-b584-7b6f04e2e1cd", "No", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "No", "812 Julianne Mill, East Merl, Uganda", -11991.937041239220000m, "Morissette, Schuppe and Considine LLC", "Sim Littel", "Customer Assurance Officer", new DateTime(2011, 4, 8, 15, 48, 9, 0, DateTimeKind.Unspecified), "f5245790-d448-4ffe-b360-0d27326aff38", "149.219.52.59", 69130.412868960640000m, 57138.475827721420000m, "Katlynn64@hotmail.com", "a9b89e63-e19a-4589-9e25-ded22f4a6727", "Yes", "02175582811", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "No", "8239 Simone Plains, New Ebba, Qatar", 48409.380021702060000m, "Reichert, Predovic and Treutel Group", "Emanuel Bechtelar", "Global Program Liaison", new DateTime(2009, 8, 9, 5, 39, 53, 0, DateTimeKind.Unspecified), "a6181260-5602-4178-b089-9427189a1b1b", "68.109.171.136", 20655.367191023680000m, 69064.747212725740000m, "Sterling_McGlynn@gmail.com", "86983d3d-1c23-416e-b7d9-dcff4ec10bef", "No", "02191901008", "Passive", null, null, null },
                    { 3, "Yes", "869 Hand Throughway, New Mollieport, Cook Islands", 10492.7587343530740000m, "Torp, Hudson and Cummerata Inc", "Leopoldo Ullrich", "Forward Integration Director", new DateTime(2002, 2, 26, 21, 32, 21, 0, DateTimeKind.Unspecified), "f1959cc8-662f-4299-9b4c-bab22ce00707", "152.153.252.62", 17744.6421170955460000m, 28237.400851448620000m, "Jedidiah.Walsh82@gmail.com", "bcd6d9fd-069c-4f2d-ba5d-9a16bcdd0a91", "No", "02121794285", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Yes", "170 Randy Landing, Hackettton, Guinea", -36213.413909772780000m, "Williamson, Zemlak and Parker LLC", "Hanna Hegmann", "Future Interactions Associate", new DateTime(2015, 9, 13, 1, 50, 8, 0, DateTimeKind.Unspecified), "13c62166-9600-48b3-a565-a0ad92eb9b84", "38.64.36.93", 72828.639651628090000m, 36615.225741855310000m, "Flavio_Green55@gmail.com", "9904cc6d-7240-49e1-a52c-198b28c3409c", "No", "02172782394", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "No", "0309 Keebler Loaf, Nealfurt, Spain", -15900.722905958280000m, "Strosin, Langworth and Gutmann Group", "Rodger Upton", "Principal Tactics Architect", new DateTime(2011, 9, 9, 8, 10, 24, 0, DateTimeKind.Unspecified), "92a3e21c-1f8e-4a42-b355-8b2c9d95ff53", "168.104.70.93", 81916.226584519240000m, 66015.503678560960000m, "Thea.Daniel0@hotmail.com", "17d74f12-5bd3-4646-b56b-f98635d1ca41", "No", "02176828220", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "872 Trudie Heights, Erdmanburgh, Jersey", "Balistreri - Will Group", "Elinore Lesch", "District Infrastructure Associate", new DateTime(2013, 5, 25, 8, 39, 47, 0, DateTimeKind.Unspecified), "cf0d41da-1085-4fbc-a50d-47129fdb96e8", "207.16.147.234", "Ron.Gibson@gmail.com", "eb058fd4-45f8-4007-956a-dd5cb80b139a", "No", "02158118592", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "54603 Aryanna Branch, Mervinview, Northern Mariana Islands", "Rodriguez, Fahey and Kshlerin Group", "Maxine Swift", "Chief Research Developer", new DateTime(2001, 5, 7, 21, 59, 6, 0, DateTimeKind.Unspecified), "ffae9207-936a-4d96-b12f-336a98093c96", "149.46.4.192", "Clinton31@gmail.com", "3348966e-527e-4d6a-9874-86a0d11c9c11", "No", "02170072054", "Active", null, null, null },
                    { 3, "109 Carroll Landing, Rodolfoborough, Turks and Caicos Islands", "Emmerich and Sons Inc", "Dean Stehr", "Dynamic Brand Assistant", new DateTime(2020, 5, 1, 12, 24, 49, 0, DateTimeKind.Unspecified), "1ade3610-a5c3-40b7-9b1e-05846456cd0b", "151.247.174.216", "Hilda.Kohler@hotmail.com", "8cf28e07-a097-4f50-b9a4-8af8f8a6cc03", "No", "02197907379", "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "71088 Adrienne Station, North Velvaside, Antarctica (the territory South of 60 deg S)", "Block - Mante and Sons", "Eudora Johnson", "Customer Implementation Manager", new DateTime(2005, 4, 2, 21, 36, 43, 0, DateTimeKind.Unspecified), "9b850f93-78bc-49bf-ad84-ef2190d4a40d", "130.73.53.204", "Vickie.McCullough@yahoo.com", "d86028e7-3716-49ba-be49-331354b130ab", "No", "02151701012", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "84382 Lind Club, West Bria, Greece", "Prohaska LLC Group", "Joyce Barrows", "Investor Program Officer", new DateTime(2003, 3, 8, 9, 24, 12, 0, DateTimeKind.Unspecified), "1de8d9ad-3ece-46d7-a63b-6a9b70abee2d", "71.228.57.138", "Clinton_Parker@hotmail.com", "4527116e-73f6-4bc9-8cbb-ca73bd987700", "No", "02133372717", "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "Status", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 2, 24, 0, 0), new DateTime(2004, 12, 17, 22, 30, 16, 0, DateTimeKind.Unspecified), "c3f3f0d1-e050-4e20-8088-35162c7a13ab", "152.79.191.215", "aut", "60ba21dc-de83-4f4d-b21e-9c3ecf8dd392", "No", "No", "No", "Active", "Yes", 2, null, null, null },
                    { 2, new TimeSpan(0, 0, 55, 0, 0), new DateTime(2019, 8, 8, 22, 31, 11, 0, DateTimeKind.Unspecified), "d6194ac1-2c09-4e01-9b45-13527b6d2051", "32.112.16.131", "cumque", "5fe208f4-7d15-44ee-9730-c73d20e662fb", "Yes", "Yes", "No", "Passive", "No", 3, null, null, null },
                    { 3, new TimeSpan(0, 2, 25, 0, 0), new DateTime(2006, 9, 23, 13, 34, 38, 0, DateTimeKind.Unspecified), "5eebede7-1bde-4365-b102-e0cd081b0d14", "150.143.211.189", "illum", "f9b75f1a-6e78-41c5-b9dd-157a76fb9e5a", "No", "Yes", "No", "Active", "No", 5, null, null, null },
                    { 4, new TimeSpan(0, 0, 57, 0, 0), new DateTime(2014, 10, 16, 5, 59, 19, 0, DateTimeKind.Unspecified), "3e4839ea-39ff-48a7-a593-759a0d41bb87", "77.164.162.196", "consequatur", "08ae4f8d-2e1e-4b4c-a8f4-33746296b434", "Yes", "No", "No", "Active", "Yes", 0, null, null, null },
                    { 5, new TimeSpan(0, 2, 48, 0, 0), new DateTime(2000, 10, 5, 3, 18, 12, 0, DateTimeKind.Unspecified), "e49a53c5-bbca-4b88-9585-e69105cf3859", "254.254.80.20", "atque", "90140862-399e-49be-9d9a-049799b51fd8", "No", "No", "No", "Passive", "No", 3, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "8118 Hahn Circles, Raybury, Iceland", "Jenkins, Glover and Conroy Group", "Ewell Christiansen", "Chief Quality Technician", new DateTime(2015, 8, 3, 5, 12, 45, 0, DateTimeKind.Unspecified), "cfc0e29a-2105-421d-955b-795e201b5bc5", "22.210.60.242", "Dino_McKenzie@yahoo.com", "5c747b3a-5cb7-48b5-8faf-66f7dbc3fa80", "No", "02119437411", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "75092 Kacey Key, South Raphaelle, Pitcairn Islands", "Bergstrom, Bashirian and Gusikowski LLC", "Tia Gleichner", "Future Group Architect", new DateTime(2012, 10, 9, 15, 58, 44, 0, DateTimeKind.Unspecified), "4dfc18e2-09e2-475d-8143-6b31eeb59242", "53.238.141.19", "Abel_Von98@yahoo.com", "a2030525-a55b-44a4-81c2-419115b899ce", "No", "02165580836", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "0077 Dare Dam, Kesslertown, Tuvalu", "Cartwright - Larson Inc", "Lyda Lowe", "Dynamic Solutions Producer", new DateTime(2004, 6, 26, 2, 53, 48, 0, DateTimeKind.Unspecified), "56a803b8-141a-47db-a808-e5c142cb8f67", "93.225.8.3", "Christophe_Funk16@yahoo.com", "52a427ea-df8f-48c9-a3e5-bed6e819a3d2", "Yes", "02126049614", "Passive", null, null, null },
                    { 4, "266 Liam Forge, Isacshire, Guam", "Cummerata - Lueilwitz LLC", "Gaylord Towne", "Internal Creative Representative", new DateTime(2014, 10, 6, 13, 45, 43, 0, DateTimeKind.Unspecified), "ba1f1d1f-da20-4f65-8707-14dcac3c301f", "95.255.25.42", "Alba_Williamson15@hotmail.com", "e42d61aa-af03-451b-9982-a1aea0a8f149", "No", "02192357526", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "10804 Mike Centers, New Shanieberg, Namibia", "Stracke and Sons Group", "Jeffrey Runolfsdottir", "Legacy Mobility Developer", new DateTime(2016, 1, 9, 2, 14, 21, 0, DateTimeKind.Unspecified), "3a7daa33-0df1-4049-a3a5-b0768159e178", "134.37.155.239", "Will_Weimann@hotmail.com", "aa89caa0-4cd6-475c-8413-4509521da2d7", "No", "02147802341", null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Unknown", "voluptatem", new DateTime(2010, 10, 26, 18, 18, 46, 0, DateTimeKind.Unspecified), "2bae8c4f-0354-47e7-a87d-74c7ee57591c", "51.44.131.126", "Internal Station system-worthy Officer Program solid state Legacy Realigned", new DateTime(2014, 6, 26, 22, 57, 50, 0, DateTimeKind.Unspecified), "a5e53470-3cac-479e-a71f-97c074339b59", "No", 3, new DateTime(2014, 6, 26, 14, 57, 50, 0, DateTimeKind.Unspecified), "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Diving", "quasi", new DateTime(2006, 1, 23, 3, 50, 47, 0, DateTimeKind.Unspecified), "f75115fa-6739-460b-bc0d-7711737092e9", "142.133.40.28", "Total Fantastic Fresh Computer generating strategize SDD Coordinator payment e-business", new DateTime(2014, 11, 2, 19, 21, 16, 0, DateTimeKind.Unspecified), "50d22213-2836-41b1-bb6b-71c75f2716b2", "No", 2, new DateTime(2014, 11, 2, 10, 21, 16, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "AncientCity", "maxime", new DateTime(2012, 1, 25, 2, 9, 23, 0, DateTimeKind.Unspecified), "08f0f73e-e4f4-4613-a8be-d786de1a4070", "218.153.165.73", "compelling Buckinghamshire Wallis and Futuna Borders back-end Personal Loan Account Louisiana cultivate", new DateTime(2014, 2, 16, 11, 57, 20, 0, DateTimeKind.Unspecified), "41a8876b-c9b3-452b-b02e-797aac8d2255", "No", 1, new DateTime(2014, 2, 16, 3, 57, 20, 0, DateTimeKind.Unspecified), "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "BBQ_Camping", "dolor", new DateTime(2001, 8, 15, 17, 57, 35, 0, DateTimeKind.Unspecified), "a6c9c307-33e9-46d8-a5a7-03af23f10b01", "146.126.118.103", "magenta Accounts parsing Dam Web purple Uzbekistan Sum India", new DateTime(2001, 9, 12, 13, 48, 24, 0, DateTimeKind.Unspecified), "70c5bc44-bae9-49ab-879f-11969458fee6", "No", 5, new DateTime(2001, 9, 12, 5, 48, 24, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Museum", "dolorem", new DateTime(2007, 7, 13, 7, 56, 50, 0, DateTimeKind.Unspecified), "66ffdebf-23f0-47ad-bf2a-32670165bb01", "215.247.135.115", "deposit Fantastic Fresh Shirt Borders Russian Ruble Focused calculating Burundi Franc invoice", new DateTime(2005, 5, 12, 1, 21, 15, 0, DateTimeKind.Unspecified), "d0e2aa1c-63f8-487f-986b-60a4dcf97f70", "No", 5, new DateTime(2005, 5, 11, 13, 21, 15, 0, DateTimeKind.Unspecified), "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "c42685a3-7635-4906-8c82-7f6100c5dc21", 5, new DateTime(2000, 6, 27, 8, 45, 17, 0, DateTimeKind.Unspecified), "1036d0ac-47eb-4629-99f4-e4f61080cf70", "130.236.123.191", "Devon.Toy@gmail.com", false, "81ed03ab-0aa6-45eb-8854-5617c2aec3eb", "No", false, new DateTimeOffset(new DateTime(2025, 5, 23, 3, 15, 15, 99, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, 3, 0, 0, 0)), "DEVON.TOY@GMAİL.COM", "SYLVESTER", "$2a$11$XwaYCkL5w./CLY5hpw4NEu35j5MDAn/uZYGBn0n5TZijD6jKVlMXG", "05222418954", false, null, "Passive", false, null, null, null, "Sylvester" },
                    { 2, 0, "52b1f304-403d-41e0-8705-bd70e05f1c93", 3, new DateTime(2021, 4, 11, 4, 51, 35, 0, DateTimeKind.Unspecified), "c8c319fe-36ab-4e74-9a10-1a972dc879b5", "163.92.15.242", "Lillian.Treutel2@hotmail.com", false, "a2827f88-cd2b-447d-ab96-6c61f85ebd8d", "Yes", false, new DateTimeOffset(new DateTime(2025, 5, 23, 3, 15, 15, 222, DateTimeKind.Unspecified).AddTicks(9369), new TimeSpan(0, 3, 0, 0, 0)), "LİLLİAN.TREUTEL2@HOTMAİL.COM", "ZACK", "$2a$11$pEPerNamc7yBnL8.TC9SFOulE4n6XsK6KhQZWr4.Bd8UmKX.afTa2", "05984426764", false, null, "Passive", false, null, null, null, "Zack" },
                    { 3, 0, "27c8cefe-268d-4a36-99ad-a8ccb9c4aa7b", 4, new DateTime(2005, 3, 15, 18, 23, 14, 0, DateTimeKind.Unspecified), "4dc4e16a-8a92-4cbd-8099-0ebacd1882d2", "247.74.193.43", "Lucile55@yahoo.com", false, "74ffc4d3-851e-4d76-850c-44d7e5f16a62", "No", false, new DateTimeOffset(new DateTime(2025, 5, 23, 3, 15, 15, 353, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 3, 0, 0, 0)), "LUCİLE55@YAHOO.COM", "ANTONİA", "$2a$11$MIK2c6eNFCPespSVpfuDoO6WtS2mD2xtLKuhoEs.C.Jy1606OUPh2", "05766635336", false, null, "Active", false, null, null, null, "Antonia" },
                    { 4, 0, "e1b46be0-3f58-4d7a-a49d-b43e9f0579b9", 1, new DateTime(2021, 4, 20, 20, 45, 21, 0, DateTimeKind.Unspecified), "d032322a-c7e2-4f0a-aa54-58dec9a58cd9", "171.79.1.116", "Shawna17@yahoo.com", false, "7a9716d2-0193-4813-849e-aea253df6e46", "No", false, new DateTimeOffset(new DateTime(2025, 5, 23, 3, 15, 15, 477, DateTimeKind.Unspecified).AddTicks(8985), new TimeSpan(0, 3, 0, 0, 0)), "SHAWNA17@YAHOO.COM", "PEYTON", "$2a$11$arjOAgKn2Jgg0XJl2IqT/.NXqNXzbS5wcwWyCDK2/3K/fWsC9ti36", "05204619393", false, null, "Passive", false, null, null, null, "Peyton" },
                    { 5, 0, "07573de4-8e30-455e-a2c9-a84db5dfb63d", 1, new DateTime(2011, 6, 2, 1, 50, 23, 0, DateTimeKind.Unspecified), "e84e5500-9c20-47a1-9c68-d8b5056a3b66", "226.11.254.220", "Kari.Prosacco66@hotmail.com", false, "b04924f7-bfa5-41f8-a4a7-2afc928ccba0", "No", false, new DateTimeOffset(new DateTime(2025, 5, 23, 3, 15, 15, 601, DateTimeKind.Unspecified).AddTicks(7288), new TimeSpan(0, 3, 0, 0, 0)), "KARİ.PROSACCO66@HOTMAİL.COM", "IAN", "$2a$11$Xo7itsvQ7cKuch3ivFS7Uu17ip0tHFgaXBTAlGRR7K2Wr6Z4PInv2", "05259720609", false, null, "Active", false, null, null, null, "Ian" }
                });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "Wales", (byte)49, new DateTime(1976, 1, 16, 13, 19, 20, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 11, 3, 23, 26, 0, DateTimeKind.Unspecified), "069e20b9-2f52-4e7d-8dc1-2746a6293786", "44.20.212.244", "ADB", "Lynn58@gmail.com", new DateTime(2019, 10, 26, 17, 17, 33, 0, DateTimeKind.Unspecified), 1, "Louie", "LouieMcDermott", 0, "60489144-e57f-4eb4-a600-569ac2bf6429", new DateTime(2018, 10, 26, 17, 17, 33, 0, DateTimeKind.Unspecified), "No", "Arabic", "McDermott", "05714504514", "http://ashton.info/ergonomic-steel-shoes", "Active", 1, "80347125796", null, null, null },
                    { 2, "Northern Ireland", (byte)48, new DateTime(1976, 12, 12, 22, 54, 4, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 19, 1, 13, 46, 0, DateTimeKind.Unspecified), "22cdb561-576c-4424-8bbb-33a8042f1244", "45.119.170.212", "B", "Irving_Nader@yahoo.com", new DateTime(2013, 2, 26, 13, 21, 7, 0, DateTimeKind.Unspecified), 3, "Marquis", "MarquisSwaniawski", 1, "d178fffb-278e-42c9-a5a0-c30b34647d6c", new DateTime(2012, 2, 26, 13, 21, 7, 0, DateTimeKind.Unspecified), "Yes", "Italian", "Swaniawski", "05054266615", "https://leonard.net/small-cotton-soap", "Active", 2, "24059709462", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "Wales", (byte)56, new DateTime(1968, 9, 20, 18, 15, 14, 0, DateTimeKind.Unspecified), new DateTime(2007, 10, 23, 12, 37, 51, 0, DateTimeKind.Unspecified), "bacce67e-39ad-43c3-b3da-917a0f5ed5b5", "157.106.92.189", "B", "Thad_Hyatt@gmail.com", new DateTime(2001, 8, 20, 15, 16, 11, 0, DateTimeKind.Unspecified), 4, "Cristian", "CristianMaggio", 1, "0505dfdc-ab7f-4057-b99a-dcff576dfcbe", new DateTime(2000, 8, 20, 15, 16, 11, 0, DateTimeKind.Unspecified), "No", "Russian", "Maggio", "05090716707", "http://rodger.biz/bypassing", 1, "61549493137", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "England", (byte)44, new DateTime(1980, 8, 26, 9, 53, 50, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 3, 3, 8, 41, 0, DateTimeKind.Unspecified), "e5b33bd2-df50-4100-a715-622f199db594", "16.174.250.140", "None", "Garfield21@gmail.com", new DateTime(2004, 9, 7, 11, 23, 38, 0, DateTimeKind.Unspecified), 4, "Grover", "GroverMarks", 2, "c1ac4746-54d4-473e-a6d9-ef5ed320c644", new DateTime(2003, 9, 7, 11, 23, 38, 0, DateTimeKind.Unspecified), "Yes", "Russian", "Marks", "05266872239", "http://clint.net/deliver/guatemala/grey", "Passive", 3, "59720158012", null, null, null },
                    { 5, "England", (byte)58, new DateTime(1966, 11, 14, 3, 26, 33, 0, DateTimeKind.Unspecified), new DateTime(2008, 6, 20, 3, 27, 28, 0, DateTimeKind.Unspecified), "3bfd0ac2-082e-4375-85b5-664f9c5449b7", "230.224.165.206", "ADB", "Giovani_Borer71@hotmail.com", new DateTime(2007, 11, 2, 22, 28, 21, 0, DateTimeKind.Unspecified), 1, "Rogelio", "RogelioDeckow", 1, "0da7784f-0537-42ac-b510-108f0a72c831", new DateTime(2006, 11, 2, 22, 28, 21, 0, DateTimeKind.Unspecified), "No", "Arabic", "Deckow", "05972298346", "http://marianna.org/benchmark", "Passive", 2, "20594778668", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Northern Ireland", (byte)49, new DateTime(1975, 11, 26, 21, 49, 27, 0, DateTimeKind.Unspecified), 4, 4, new DateTime(2007, 5, 18, 2, 21, 7, 0, DateTimeKind.Unspecified), "f172f055-7b22-4bc3-b1b7-dba302404b6f", "175.41.176.88", "Consulting", 3366, "Sienna_Crona82@gmail.com", new DateTime(2028, 2, 26, 14, 44, 21, 0, DateTimeKind.Unspecified), 16, "Eleonore", "EleonoreMarks", "3a909c5b-0b72-48b1-b98b-1b46229fc94a", new DateTime(2016, 2, 26, 14, 44, 21, 0, DateTimeKind.Unspecified), "No", "Marks", "05638321243", "http://lonie.org/internet-solution/salmon", "Passive", "56417732072", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "England", (byte)61, new DateTime(1964, 3, 5, 10, 34, 39, 0, DateTimeKind.Unspecified), 8, 1, new DateTime(2010, 12, 12, 12, 59, 14, 0, DateTimeKind.Unspecified), "8a45b8c7-3318-4fb7-bf92-609a6c9d1cad", "114.20.179.249", "IT", 8002, "Marianna_Upton@gmail.com", new DateTime(2027, 6, 18, 9, 23, 43, 0, DateTimeKind.Unspecified), 17, "Nya", "NyaMurray", "f5e07b0a-cd5c-42d4-b4be-847fce24d8da", new DateTime(2003, 6, 18, 9, 23, 43, 0, DateTimeKind.Unspecified), "No", "Murray", "05952191828", "http://helga.net/metrics/intuitive", "05661491366", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "Wales", (byte)53, new DateTime(1971, 9, 20, 17, 8, 29, 0, DateTimeKind.Unspecified), 3, 5, new DateTime(2010, 1, 16, 17, 37, 18, 0, DateTimeKind.Unspecified), "7e8d8135-8286-4e19-87e8-3ec47d47dd27", "92.58.114.145", "Marketing", 2100, "Dillon.Lindgren47@gmail.com", new DateTime(2028, 8, 15, 17, 26, 47, 0, DateTimeKind.Unspecified), 14, "Mose", "MoseKlein", "Female", "e715e276-3114-4b18-8f2c-3800479b246c", new DateTime(2019, 8, 15, 17, 26, 47, 0, DateTimeKind.Unspecified), "No", "Klein", "05132900767", "http://grady.name/florida/track", "Passive", "00896199908", null, null, null },
                    { 4, "Northern Ireland", (byte)46, new DateTime(1978, 6, 11, 7, 44, 20, 0, DateTimeKind.Unspecified), 4, 2, new DateTime(2008, 2, 26, 21, 14, 38, 0, DateTimeKind.Unspecified), "f89f3419-6792-46c9-b2e3-df718bc89ed4", "230.190.203.161", "IT", 3098, "Mose90@yahoo.com", new DateTime(2028, 11, 20, 5, 25, 32, 0, DateTimeKind.Unspecified), 7, "Katrina", "KatrinaSchowalter", "Female", "24b171aa-f614-4cb9-b504-0cf4620d7513", new DateTime(2016, 11, 20, 5, 25, 32, 0, DateTimeKind.Unspecified), "No", "Schowalter", "05245276329", "https://lily.biz/open-system/michigan", "Active", "54930211866", null, null, null },
                    { 5, "Wales", (byte)51, new DateTime(1974, 3, 2, 19, 17, 24, 0, DateTimeKind.Unspecified), 8, 1, new DateTime(2001, 4, 14, 9, 38, 4, 0, DateTimeKind.Unspecified), "5c1b9e97-0373-4726-ae98-b9cbdfdbf07d", "219.104.197.131", "Operations", 8055, "Jesus32@yahoo.com", new DateTime(2027, 4, 26, 22, 36, 21, 0, DateTimeKind.Unspecified), 5, "Ava", "AvaOrtiz", "Female", "b3f8b2cc-386d-4ae1-b9f1-1735069c35e3", new DateTime(2003, 4, 26, 22, 36, 21, 0, DateTimeKind.Unspecified), "No", "Ortiz", "05695798515", "https://deangelo.net/movies-movies--clothing/hawaii/producer", "Active", "78695256137", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, new DateTime(2003, 7, 17, 16, 15, 46, 0, DateTimeKind.Unspecified), "2b11a78c-3247-46fb-93a5-48f35f121c06", "249.22.163.17", "2f12a044-46ed-423b-867e-001b2b541588", "No", 3, 13427.556303740732000m, "Sale", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "Status", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 6, 19, 15, 20, 36, 0, DateTimeKind.Unspecified), "2fa50815-0300-4b6a-af20-4a496e057517", "106.183.68.37", "5522f58c-96d6-47e1-92ef-59eb1baa8ec2", "No", 3, "Passive", 2857.918206247824000m, "Sale", null, null, null },
                    { 3, new DateTime(2013, 6, 14, 20, 16, 20, 0, DateTimeKind.Unspecified), "a1f74c11-e6fd-4dcf-87c8-ba89bdfd3326", "34.197.117.250", "dbb52404-4947-49c6-a6e7-d8f203245335", "No", 1, "Active", 13398.857030857024000m, "Sale", null, null, null },
                    { 4, new DateTime(2003, 4, 5, 6, 21, 15, 0, DateTimeKind.Unspecified), "217020f9-27fa-405c-9c36-e6192c3c77b1", "97.15.23.31", "f0fb805a-bf15-4f89-ba1c-9229487f221a", "No", 2, "Active", 12270.261896396832000m, "Sale", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new DateTime(2014, 8, 2, 1, 12, 17, 0, DateTimeKind.Unspecified), "36179a48-e8ad-4f20-991f-0514b4bc0839", "59.49.176.150", "720bb6de-7c16-430e-a12c-636104c608ea", "No", 4, 9319.765671217490000m, "Sale", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, (byte)20, new DateTime(2020, 8, 17, 6, 24, 41, 0, DateTimeKind.Unspecified), "c02da8cc-7e95-4dc8-bb70-b5ae1cdfeebc", "170.44.47.1", "ef8af093-a413-4a54-b2fb-ecc69d8d3d48", "No", 3, 199.713728099778880m, "Passive", 239.656473719734656m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, (byte)9, new DateTime(2018, 8, 10, 23, 47, 2, 0, DateTimeKind.Unspecified), "92b4e568-1a91-4266-90de-4bd08d4379b9", "216.249.7.61", "48af16a5-1c02-41c5-94d8-4f92770b8820", "No", 2, 293.858518437168960m, 320.3057850965141664m, null, null, null },
                    { 3, (byte)13, new DateTime(2011, 11, 23, 19, 19, 54, 0, DateTimeKind.Unspecified), "ed951c27-6f54-4d74-8c5e-d4a3355347b9", "131.18.10.118", "fd0dbc8d-11cb-4b86-8124-abc6492bd019", "No", 5, 209.520969039443840m, 236.7586950145715392m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, (byte)17, new DateTime(2006, 3, 7, 23, 39, 53, 0, DateTimeKind.Unspecified), "80491ee7-d592-472d-a67e-581a845ad60a", "130.28.77.3", "afa8e85c-ec9b-469c-9582-48e202fd9ea0", "No", 4, 315.615016446602240m, "Passive", 369.2695692425246208m, null, null, null },
                    { 5, (byte)10, new DateTime(2016, 1, 13, 3, 54, 2, 0, DateTimeKind.Unspecified), "852285ba-075d-4488-a423-8e773a0bee7a", "183.245.243.22", "c349aff3-802a-4707-bb7e-911c5a8870a6", "No", 3, 204.130700889027520m, "Passive", 224.543770977930272m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 6, 20, 23, 14, 25, 0, DateTimeKind.Unspecified), "de8fcb41-d040-48e7-a0e5-b7e9edbea8a0", "37.45.235.37", 3, "941838b7-89b6-4eb9-a0c8-2f26bc19f3bc", "Yes", "backing up RSS Gorgeous Rubber Towels Utah", "Passive", null, null, null, 2, "Lizeth.Wuckert77@gmail.com" },
                    { 2, new DateTime(2017, 6, 2, 3, 41, 11, 0, DateTimeKind.Unspecified), "ab4688a6-61a3-49bd-b5d1-cbd41aa7d6a9", "70.1.193.244", 5, "a7b5fc59-8f3b-4406-a3cd-c7dd4f42e3df", "Yes", "unleash Horizontal Cambridgeshire web-enabled", "Active", null, null, null, 1, "Stewart22@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 3, new DateTime(2004, 3, 22, 15, 18, 40, 0, DateTimeKind.Unspecified), "59547d1e-e1d5-43de-bd27-88d77a1fc470", "78.80.153.13", 5, "7dc12de3-7c41-4bd6-ac95-4fbaa39e9708", "Yes", "online Refined Frozen Sausages Northern Mariana Islands Tools & Sports", null, null, null, 5, "Trey.Haley@hotmail.com" },
                    { 4, new DateTime(2001, 5, 19, 2, 45, 35, 0, DateTimeKind.Unspecified), "88179b4e-1dd1-4e74-a371-4c6427764b86", "114.42.74.9", 4, "87fac73d-492d-4682-a161-75311dfbb799", "No", "Facilitator Fort SMTP array", null, null, null, 4, "David_West97@hotmail.com" },
                    { 5, new DateTime(2001, 12, 6, 22, 27, 28, 0, DateTimeKind.Unspecified), "bbd39932-bdc1-4854-b35d-38ed81b188c4", "152.81.169.247", 5, "296358bb-6295-4a2e-9a99-24888a0ab455", "No", "Orchestrator Michigan Intelligent Plastic Pants Berkshire", null, null, null, 4, "Lelah14@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, 5, new DateTime(2012, 6, 19, 4, 32, 44, 0, DateTimeKind.Unspecified), new DateTime(2013, 3, 10, 20, 34, 39, 0, DateTimeKind.Unspecified), "9264a515-fd65-46ba-a287-7cea1a1d1603", "61.213.65.177", "USD", "Granite Incredible Plastic Cheese", new DateTime(2012, 6, 19, 1, 32, 44, 0, DateTimeKind.Unspecified), "Borders British Indian Ocean Territory (Chagos Archipelago)", (byte)19, "942d7033-78e4-44a8-9135-b31e2bb28c8e", "No", 232.915415593872240m, "PartialPaid", 287.549895794904000m, "C245", "Emilia Franecki", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "Status", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, 5, new DateTime(2011, 2, 4, 2, 48, 23, 0, DateTimeKind.Unspecified), new DateTime(2002, 10, 2, 20, 26, 46, 0, DateTimeKind.Unspecified), "d346ca82-bf89-4190-862b-2a3994d43a00", "188.102.67.242", "GBP", "Sports & Outdoors Shoes, Tools & Baby", new DateTime(2011, 2, 3, 23, 48, 23, 0, DateTimeKind.Unspecified), "deliver Personal Loan Account", (byte)12, "abae6ff1-9dff-4ed4-8baa-aeb327b36c58", "Yes", 297.269530306122880m, "FullyPaid", 337.806284438776000m, "C228", "Active", "Jude Breitenberg", null, null, null },
                    { 3, 1, new DateTime(2018, 6, 27, 1, 19, 42, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 11, 8, 38, 27, 0, DateTimeKind.Unspecified), "9f84c730-b833-4921-bb93-8bc1fdd701d8", "68.163.130.173", "CNY", "Technician invoice", new DateTime(2018, 6, 26, 22, 19, 42, 0, DateTimeKind.Unspecified), "Kazakhstan Intuitive", (byte)19, "ddb825c1-6f7b-47b2-bcbf-71914897db27", "No", 193.2865147502542656m, "PartialPaid", 238.625326852165760m, "C142", "Active", "Amari VonRueden", null, null, null },
                    { 4, 3, new DateTime(2008, 11, 13, 4, 51, 44, 0, DateTimeKind.Unspecified), new DateTime(2016, 6, 8, 15, 30, 42, 0, DateTimeKind.Unspecified), "c83019d3-6534-49f3-9627-6715b3184081", "192.74.228.35", "TRY", "best-of-breed content-based", new DateTime(2008, 11, 13, 1, 51, 44, 0, DateTimeKind.Unspecified), "Guinea Franc portals", (byte)14, "dd28045b-929f-47eb-a0f0-cfc4fc4585c9", "No", 324.1571110089928192m, "Pending", 376.926873266270720m, "A24", "Passive", "Cristobal Schaefer", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, 1, new DateTime(2009, 4, 17, 19, 19, 3, 0, DateTimeKind.Unspecified), new DateTime(2007, 7, 13, 23, 49, 30, 0, DateTimeKind.Unspecified), "26196a13-e743-4937-bd71-0e8ccf2b68d4", "148.204.120.92", "JPY", "Village Small Fresh Mouse", new DateTime(2009, 4, 17, 16, 19, 3, 0, DateTimeKind.Unspecified), "bypassing Corners", (byte)20, "bbdb2af5-cc9f-4891-8130-54f0fd57f234", "Yes", 159.975266216292096m, "PartialPaid", 199.969082770365120m, "C171", "Britney Harber", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "602 Mathew Loop, North Stanmouth, Brunei Darussalam", (byte)61, new DateTime(1964, 1, 9, 20, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2012, 9, 2, 20, 50, 45, 0, DateTimeKind.Unspecified), "f162f5a5-df47-4e34-94cf-35c07fe74b12", "55.189.32.17", "Elisha", "Female", "Yes", "Lind", "emely.org", "Active", "34198492179", new DateTime(2022, 3, 23, 8, 43, 19, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "58492 Paucek Harbor, South Earnestine, Pakistan", (byte)26, new DateTime(1998, 7, 21, 20, 21, 34, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 7, 16, 43, 50, 0, DateTimeKind.Unspecified), "b89c1f88-bc50-4ad0-b180-9c4837fe6cb3", "254.146.176.247", "Oma", "No", "Rau", "alec.info", "Active", "23744913769", new DateTime(2023, 12, 4, 4, 18, 52, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "261 Wisoky Islands, Margaritaport, Isle of Man", (byte)27, new DateTime(1997, 9, 10, 7, 33, 28, 0, DateTimeKind.Unspecified), new DateTime(2009, 4, 21, 4, 51, 31, 0, DateTimeKind.Unspecified), "d5c966c1-ca2f-4dfc-b8ef-1fbf1804d240", "173.52.91.69", "Savannah", "Male", "No", "Larson", "sandrine.info", "34336497965", new DateTime(2022, 1, 23, 18, 25, 54, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "3652 Abdullah Ramp, Wolffchester, Azerbaijan", (byte)73, new DateTime(1951, 9, 18, 22, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2012, 4, 22, 16, 19, 50, 0, DateTimeKind.Unspecified), "3f47774a-02e3-478b-88ff-9ac7e0201bee", "78.146.92.64", "Abagail", "No", "Marquardt", "charlene.net", "Active", "58183242902", new DateTime(2024, 11, 10, 7, 28, 34, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "3488 Imogene Groves, Hammesfort, Iceland", (byte)26, new DateTime(1998, 5, 20, 13, 22, 15, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 27, 19, 58, 35, 0, DateTimeKind.Unspecified), "adef27f0-77a0-4ad8-b4c0-8fe3ace147c1", "159.87.69.173", "Burnice", "Male", "No", "Quigley", "zack.info", "Active", "83997329049", new DateTime(2024, 8, 17, 1, 21, 50, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 1, 4, 8, (short)73, new DateTime(2015, 12, 6, 7, 27, 25, 0, DateTimeKind.Unspecified), "9267467a-1240-4a23-95b8-f511e02cd758", "141.99.224.138", 6072m, new DateTime(2007, 12, 2, 21, 54, 28, 0, DateTimeKind.Unspecified), "04d95aef-ca6f-49e7-b9b5-0994ec2222e3", "Busy", "No", 172791, "70 ab 3243", "Focus", 3, new DateTime(2007, 12, 1, 21, 54, 28, 0, DateTimeKind.Unspecified), "Active", 6072m, 1, null, null, null, "Yacht" });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 2, 2, 15, (short)72, new DateTime(2009, 4, 14, 7, 23, 13, 0, DateTimeKind.Unspecified), "76248b6b-2cf9-453a-8ca8-05e961bf69b0", "119.197.162.116", 14601m, new DateTime(2011, 5, 21, 7, 35, 47, 0, DateTimeKind.Unspecified), "d492aff5-52aa-408c-90ae-fbc697645612", "Busy", "Yes", 322248, "46 sn 1064", "XC90", 3, new DateTime(2011, 5, 19, 7, 35, 47, 0, DateTimeKind.Unspecified), 29202m, 2, null, null, null, "Jeep" },
                    { 3, 4, 15, (short)72, new DateTime(2004, 5, 17, 10, 47, 45, 0, DateTimeKind.Unspecified), "e269c197-e6e6-41fd-a90f-0c749a2e20f1", "48.202.70.167", 10644m, new DateTime(2016, 10, 24, 16, 29, 13, 0, DateTimeKind.Unspecified), "6572ad75-7bab-489a-bd38-0c5d019838cd", "Busy", "No", 788378, "12 hy 7749", "Colorado", 2, new DateTime(2016, 10, 23, 16, 29, 13, 0, DateTimeKind.Unspecified), 10644m, 1, null, null, null, "Boat" }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 4, 1, 8, (short)44, new DateTime(2016, 2, 7, 14, 42, 9, 0, DateTimeKind.Unspecified), "fa76fa51-98cc-4006-bb36-9c01ee70a6c9", "151.118.209.43", 10227m, new DateTime(2001, 10, 28, 19, 54, 29, 0, DateTimeKind.Unspecified), "18ac3660-d4ab-4f9f-8cc7-f50a0434f4fc", "Busy", "No", 150689, "76 nw 845", "A8", 2, new DateTime(2001, 10, 23, 19, 54, 29, 0, DateTimeKind.Unspecified), "Active", 51135m, 5, null, null, null, "None" },
                    { 5, 3, 9, (short)23, new DateTime(2005, 6, 10, 11, 57, 33, 0, DateTimeKind.Unspecified), "71fde67f-9257-41dc-a3e8-355eaf895081", "37.232.199.93", 18981m, new DateTime(2000, 3, 2, 12, 51, 12, 0, DateTimeKind.Unspecified), "abea4e08-f239-4b96-bea6-5511efa8936c", "Available", "No", 13474, "55 mo 4211", "A4", 5, new DateTime(2000, 2, 26, 12, 51, 12, 0, DateTimeKind.Unspecified), "Passive", 94905m, 5, null, null, null, "None" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 1, 4, 14, (short)83, new DateTime(2019, 11, 9, 21, 53, 39, 0, DateTimeKind.Unspecified), "2cfc3586-8bea-4d9d-971f-050c9ee38558", "54.26.160.223", "84921848-f073-4444-aa62-a12dc1c8f36a", "Busy", "No", 559262, "42 cc 3121", 20401579m, "Beetle", new DateTime(2013, 8, 12, 12, 50, 41, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "None" },
                    { 2, 4, 10, (short)35, new DateTime(2011, 1, 20, 6, 32, 26, 0, DateTimeKind.Unspecified), "44d2f7e8-1445-406a-a9fd-813c008697a7", "243.8.77.252", "06be0fd8-0189-44b3-b9b9-170fb052e15e", "Busy", "No", 192278, "48 re 7995", 17271373m, "Element", new DateTime(2002, 4, 25, 15, 19, 13, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Jeep" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 3, 2, 2, (short)60, new DateTime(2002, 7, 27, 21, 9, 36, 0, DateTimeKind.Unspecified), "5b3a81c0-5d7f-455b-bb72-0b74d3f62e7e", "160.218.83.38", "0ef98284-df00-43b5-9063-11763eb25285", "Available", "No", 337383, "78 qc 5633", 18204159m, "Camaro", new DateTime(2008, 7, 6, 21, 31, 10, 0, DateTimeKind.Unspecified), null, null, null, "Minibus" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 4, 1, 1, (short)33, new DateTime(2013, 7, 16, 9, 25, 12, 0, DateTimeKind.Unspecified), "c8232a42-1a19-4409-b6a4-8ae2d6a423c0", "88.76.70.240", "f471abef-48e5-4e18-a6d5-522c367bfead", "Busy", "No", 31143, "66 pg 3661", 16867702m, "Grand Cherokee", new DateTime(2013, 9, 19, 20, 52, 11, 0, DateTimeKind.Unspecified), "Active", null, null, null, "ATV" },
                    { 5, 1, 2, (short)65, new DateTime(2009, 5, 22, 16, 33, 33, 0, DateTimeKind.Unspecified), "fcce8cae-52c1-49a8-aa7e-fe273c576e68", "120.134.159.97", "ba95f503-b673-4bf9-87c2-9368fb7e648a", "Available", "No", 161785, "80 if 5063", 16939541m, "Beetle", new DateTime(2011, 3, 3, 6, 26, 14, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Jeep" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, 1, 1, new DateTime(2011, 3, 9, 22, 52, 24, 0, DateTimeKind.Unspecified), "6ab9bb76-6df9-40b3-8758-46a13d529f4e", "65.42.104.97", 0.4739123568124565m, "d33aaf36-bb9d-4deb-9974-216a70d86370", "Yes", 2, 388.74025414899908675690512479m, 369.463395674566500m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "Status", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, 5, 1, new DateTime(2001, 12, 24, 16, 9, 20, 0, DateTimeKind.Unspecified), "6c9bcc59-2cc2-4e09-9030-edad103b8be5", "200.72.35.79", 0.3620037562933360m, "9fd59f4e-11eb-4312-986c-5074e02054ac", "No", 1, "Active", 736.94098527119732550649210151m, 1155.086714914932700m, null, null, null },
                    { 3, 3, 3, new DateTime(2013, 4, 9, 2, 59, 2, 0, DateTimeKind.Unspecified), "96eeb627-28c3-48b8-b0e3-750fe81d6210", "15.206.30.139", 0.01487695176009890m, "b645abab-52b6-426c-ac14-be41c5bd7d4a", "No", 4, "Active", 2644.6521371431787376486117185m, 671.147665732804600m, null, null, null },
                    { 4, 1, 2, new DateTime(2016, 12, 23, 20, 33, 9, 0, DateTimeKind.Unspecified), "0fc2a3dd-a146-444e-b692-46f05dfa0347", "54.25.135.121", 0.292987187736360m, "5b54ac6b-8676-45ff-8805-35b393e5baab", "No", 1, "Passive", 724.37815419229124163802340987m, 1024.561566109463700m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, 1, 1, new DateTime(2016, 8, 15, 14, 8, 17, 0, DateTimeKind.Unspecified), "5f6c9729-35b7-49ec-b609-3263f4bbcf1b", "96.153.16.2", 0.3251739613777990m, "57fae033-5dbd-4d40-a552-c7150e1414a3", "No", 1, 504.19002002696754103666290545m, 747.140731345188300m, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_RegionId",
                table: "Activities",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPassTickets_PartnerCompanyTransactionId",
                table: "ActivityPassTickets",
                column: "PartnerCompanyTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTicketOrderDetails_ActivityTicketId",
                table: "ActivityTicketOrderDetails",
                column: "ActivityTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTicketOrderDetails_ActivityTicketOrderId",
                table: "ActivityTicketOrderDetails",
                column: "ActivityTicketOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTicketOrders_EmployeeId",
                table: "ActivityTicketOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTicketOrders_WebUserAccountId",
                table: "ActivityTicketOrders",
                column: "WebUserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTickets_ActivityId",
                table: "ActivityTickets",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ContractEmployees_SupplierId",
                table: "ContractEmployees",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerCompanyTransactions_PartnerCompanyId",
                table: "PartnerCompanyTransactions",
                column: "PartnerCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_ActivityId",
                table: "RentalVehicles",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_RentalVehicleSupplierId",
                table: "RentalVehicles",
                column: "RentalVehicleSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ActivityId",
                table: "Vehicles",
                column: "ActivityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityPassTickets");

            migrationBuilder.DropTable(
                name: "ActivityTicketOrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserProfiles");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContractEmployees");

            migrationBuilder.DropTable(
                name: "RentalVehicles");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "PartnerCompanyTransactions");

            migrationBuilder.DropTable(
                name: "ActivityTicketOrders");

            migrationBuilder.DropTable(
                name: "ActivityTickets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SubContractWorkerSuppliers");

            migrationBuilder.DropTable(
                name: "RentalVehicleSuppliers");

            migrationBuilder.DropTable(
                name: "PartnerCompanies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ServiceRegions");
        }
    }
}
