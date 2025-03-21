using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CountryDescription = table.Column<string>(type: "nvarchar(190)", maxLength: 190, nullable: true),
                    CountryPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6f8d898e-5299-4437-ae0c-f89b5e7dea43"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 988, DateTimeKind.Local).AddTicks(9320)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "28bd74bb-c8f5-4581-8077-fdc7d3c0b1ab"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
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
                    CommissionRate = table.Column<decimal>(type: "decimal(7,4)", nullable: false),
                    AcceptTickets = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6369177b-b7a2-44ee-b583-85424dab896a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 987, DateTimeKind.Local).AddTicks(7410)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1ff16b98-f144-411c-aa34-52ce16728a5c"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
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
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CategoryType = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValue: "Unknown"),
                    Description = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7f2dc491-dcc6-4036-9ec9-687ddff583cb"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 992, DateTimeKind.Local).AddTicks(3832)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "32e19a0c-7b0e-4f9e-8b4d-74cf66eaba01"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c5c53b20-1081-498d-b0bc-246499a824a4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 987, DateTimeKind.Local).AddTicks(9808)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f9f43066-ad60-4846-8b4e-595ffd4b761e"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
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
                    table.PrimaryKey("PK_ProductSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalVehicleSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f496db7e-d173-47c1-bb54-6bdb0d2533e3"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 988, DateTimeKind.Local).AddTicks(2896)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a8573066-6cc3-4f55-b777-6fe7cc439660"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
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
                name: "ResidenceRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c6078be7-35d7-4cef-8cd7-16401a010f5f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 993, DateTimeKind.Local).AddTicks(464)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "57a79f52-3e26-4781-b0d7-315c3f07c40a"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    DistrictName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ArrivalTime = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    TransportVehicle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TouristPopulation = table.Column<bool>(type: "bit", nullable: false),
                    HasAirport = table.Column<bool>(type: "bit", nullable: false),
                    HasHotelFacility = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "bcf41bb2-8aca-476b-a259-76a9f2b294ce"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 993, DateTimeKind.Local).AddTicks(2738)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ce78407a-4775-4022-aed7-14a929f32b67"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    DistrictName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ArrivalTime = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    TransportVehicle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4bdcc01c-80db-4b56-8640-cf7cae09c41f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 988, DateTimeKind.Local).AddTicks(6008)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d3de92c5-054d-436a-8ac0-69ad119e29e8"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fa2b2881-60f6-45bf-8ae9-f9bfc455aa92"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 995, DateTimeKind.Local).AddTicks(4835)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b168b8c6-d9aa-44f2-ad9f-f1b6d1a85a43"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(220)", maxLength: 220, nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ProductSupplierId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "04797111-09f3-4928-b5d9-7f55f9c60cca"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 992, DateTimeKind.Local).AddTicks(7905)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f08cb5d0-66cb-4da8-b215-ec83c25ae6b2"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductSuppliers_ProductSupplierId",
                        column: x => x.ProductSupplierId,
                        principalTable: "ProductSuppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    ResidenceRegionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f723520e-7fd9-4c57-8bff-9aa56767c303"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 990, DateTimeKind.Local).AddTicks(2020)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cdb806da-5f92-4400-b145-118ff5e3367d"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Employees_ResidenceRegions_ResidenceRegionId",
                        column: x => x.ResidenceRegionId,
                        principalTable: "ResidenceRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f484e22f-64c8-4452-aa91-af39433418fe"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 986, DateTimeKind.Local).AddTicks(6415)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cf279a83-e25a-45a8-988f-5147c3e6d460"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    EventName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_ServiceRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "ServiceRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "535005a4-88d8-4ffa-bd18-603e7cc6530b"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 987, DateTimeKind.Local).AddTicks(1882)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a46f1a57-da88-4e7a-9e10-90d7839828e7"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    EventName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_ServiceRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "ServiceRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractDrivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverLicense = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValue: "None"),
                    SubContractWorkerSupplierId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "90e932f8-9a00-4e47-91d3-6fbeb7e0c01c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 989, DateTimeKind.Local).AddTicks(2341)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b834ffcc-b93f-41f6-a0bd-d99c455b89cd"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractDrivers_SubContractWorkerSuppliers_SubContractWorkerSupplierId",
                        column: x => x.SubContractWorkerSupplierId,
                        principalTable: "SubContractWorkerSuppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractTourGuides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false, defaultValue: "None"),
                    SubContractWorkerSupplierId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2c0dfc21-5450-4016-af37-eb6c7648d92f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 989, DateTimeKind.Local).AddTicks(7860)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a836402b-57c6-44d8-88ba-980b8f744ae7"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTourGuides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractTourGuides_SubContractWorkerSuppliers_SubContractWorkerSupplierId",
                        column: x => x.SubContractWorkerSupplierId,
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
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 995, DateTimeKind.Local).AddTicks(8928))
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
                name: "TourTicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d1b96e4f-9d81-4878-b6cb-398e291c1fa5"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 992, DateTimeKind.Local).AddTicks(545)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a046a459-d981-49d1-a3ed-850fd8a2348d"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    Note = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    WebUserEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    WebUserAccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourTicketOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourTicketOrders_AspNetUsers_WebUserAccountId",
                        column: x => x.WebUserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TourTicketOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "03b9d04d-38b3-4852-9526-d6fef856f7bc"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 993, DateTimeKind.Local).AddTicks(8432)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "06cc9d8b-24c5-4d76-83f8-f2e0f5b5fb68"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    VehicleType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Kilometer = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Capacity = table.Column<short>(type: "smallint", maxLength: 2, nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalVehicles_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentalVehicles_RentalVehicleSuppliers_RentalVehicleSupplierId",
                        column: x => x.RentalVehicleSupplierId,
                        principalTable: "RentalVehicleSuppliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RentalVehicles_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a412f2d1-3a19-4862-8d26-45a044d022b7"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 993, DateTimeKind.Local).AddTicks(5769)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "af902f97-abf0-4dff-839b-00ba1b7d253b"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    TicketName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DepartureAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DestinationAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourTickets_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "78ff9196-967a-4f57-8d5a-52bd3e73abb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 994, DateTimeKind.Local).AddTicks(2535)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7043538b-2154-4aba-9b61-5648cb70d8f8"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    VehicleType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Kilometer = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Capacity = table.Column<short>(type: "smallint", maxLength: 2, nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractTourGuide_Tour",
                columns: table => new
                {
                    ContractTourGuideId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTourGuide_Tour", x => new { x.ContractTourGuideId, x.TourId });
                    table.ForeignKey(
                        name: "FK_ContractTourGuide_Tour_ContractTourGuides_ContractTourGuideId",
                        column: x => x.ContractTourGuideId,
                        principalTable: "ContractTourGuides",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractTourGuide_Tour_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractTourGuides_ServiceRegions",
                columns: table => new
                {
                    ContractTourGuideId = table.Column<int>(type: "int", nullable: false),
                    ServiceRegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTourGuides_ServiceRegions", x => new { x.ContractTourGuideId, x.ServiceRegionId });
                    table.ForeignKey(
                        name: "FK_ContractTourGuides_ServiceRegions_ContractTourGuides_ContractTourGuideId",
                        column: x => x.ContractTourGuideId,
                        principalTable: "ContractTourGuides",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractTourGuides_ServiceRegions_ServiceRegions_ServiceRegionId",
                        column: x => x.ServiceRegionId,
                        principalTable: "ServiceRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractDrivers_RentalVehicles",
                columns: table => new
                {
                    ContactDriverId = table.Column<int>(type: "int", nullable: false),
                    RentalVehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDrivers_RentalVehicles", x => new { x.ContactDriverId, x.RentalVehicleId });
                    table.ForeignKey(
                        name: "FK_ContractDrivers_RentalVehicles_ContractDrivers_ContactDriverId",
                        column: x => x.ContactDriverId,
                        principalTable: "ContractDrivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractDrivers_RentalVehicles_RentalVehicles_RentalVehicleId",
                        column: x => x.RentalVehicleId,
                        principalTable: "RentalVehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourTicketOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourTicketId = table.Column<int>(type: "int", nullable: true),
                    TourTicketOrderId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7d037253-28f4-41b7-a5dc-a812a04e84de"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 13, 10, 991, DateTimeKind.Local).AddTicks(6949)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e5e99590-5f2f-4203-b71e-fb8c47fa8905"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    UnitPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourTicketOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourTicketOrderDetails_TourTicketOrders_TourTicketOrderId",
                        column: x => x.TourTicketOrderId,
                        principalTable: "TourTicketOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TourTicketOrderDetails_TourTickets_TourTicketId",
                        column: x => x.TourTicketId,
                        principalTable: "TourTickets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractDrivers_Vehicles",
                columns: table => new
                {
                    ContractDriverId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDrivers_Vehicles", x => new { x.ContractDriverId, x.VehicleId });
                    table.ForeignKey(
                        name: "FK_ContractDrivers_Vehicles_ContractDrivers_ContractDriverId",
                        column: x => x.ContractDriverId,
                        principalTable: "ContractDrivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractDrivers_Vehicles_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

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
                name: "IX_ContractDrivers_SubContractWorkerSupplierId",
                table: "ContractDrivers",
                column: "SubContractWorkerSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDrivers_RentalVehicles_RentalVehicleId",
                table: "ContractDrivers_RentalVehicles",
                column: "RentalVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDrivers_Vehicles_VehicleId",
                table: "ContractDrivers_Vehicles",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractTourGuide_Tour_TourId",
                table: "ContractTourGuide_Tour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractTourGuides_SubContractWorkerSupplierId",
                table: "ContractTourGuides",
                column: "SubContractWorkerSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractTourGuides_ServiceRegions_ServiceRegionId",
                table: "ContractTourGuides_ServiceRegions",
                column: "ServiceRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ResidenceRegionId",
                table: "Employees",
                column: "ResidenceRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_RegionId",
                table: "Events",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSupplierId",
                table: "Products",
                column: "ProductSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_EventId",
                table: "RentalVehicles",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_RentalVehicleSupplierId",
                table: "RentalVehicles",
                column: "RentalVehicleSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_TourId",
                table: "RentalVehicles",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_RegionId",
                table: "Tours",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_TourTicketOrderDetails_TourTicketId",
                table: "TourTicketOrderDetails",
                column: "TourTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TourTicketOrderDetails_TourTicketOrderId",
                table: "TourTicketOrderDetails",
                column: "TourTicketOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TourTicketOrders_EmployeeId",
                table: "TourTicketOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TourTicketOrders_WebUserAccountId",
                table: "TourTicketOrders",
                column: "WebUserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TourTickets_TourId",
                table: "TourTickets",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EventId",
                table: "Vehicles",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TourId",
                table: "Vehicles",
                column: "TourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "ContractDrivers_RentalVehicles");

            migrationBuilder.DropTable(
                name: "ContractDrivers_Vehicles");

            migrationBuilder.DropTable(
                name: "ContractTourGuide_Tour");

            migrationBuilder.DropTable(
                name: "ContractTourGuides_ServiceRegions");

            migrationBuilder.DropTable(
                name: "PartnerCompanies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TourTicketOrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "RentalVehicles");

            migrationBuilder.DropTable(
                name: "ContractDrivers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "ContractTourGuides");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductSuppliers");

            migrationBuilder.DropTable(
                name: "TourTicketOrders");

            migrationBuilder.DropTable(
                name: "TourTickets");

            migrationBuilder.DropTable(
                name: "RentalVehicleSuppliers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "SubContractWorkerSuppliers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ResidenceRegions");

            migrationBuilder.DropTable(
                name: "ServiceRegions");
        }
    }
}
