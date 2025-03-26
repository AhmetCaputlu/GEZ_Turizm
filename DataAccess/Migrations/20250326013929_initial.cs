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
                    CountryDescription = table.Column<string>(type: "nvarchar(190)", maxLength: 190, nullable: true),
                    CountryPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "18f6d9bd-56f6-4bd9-96fd-5b537d714139"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 378, DateTimeKind.Local).AddTicks(3916)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6029b8bf-c04f-4c62-a3b4-e228e344b57c"),
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
                    AcceptTickets = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "360355d4-d898-4e84-9303-9a7d15b4b799"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 376, DateTimeKind.Local).AddTicks(4256)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "94d86e07-6ea6-49bb-a5ab-263e52cbf3c9"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4ee1493e-6cd4-4157-8ac5-f9c2c8374555"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 385, DateTimeKind.Local).AddTicks(7550)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ff3fdb15-3ce6-4cd9-bac4-88f36d8461f6"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "dbb22484-f6e8-429a-a85c-6a789f357734"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 377, DateTimeKind.Local).AddTicks(1839)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "02701569-e44a-4772-be95-20a071178143"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b137304e-9e2e-4987-b90b-826029a765eb"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 377, DateTimeKind.Local).AddTicks(5829)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "faae95a4-272d-4801-af74-6291083ef44b"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "eeeb7b03-8c85-4b72-93ff-fafdae9dd8fb"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 386, DateTimeKind.Local).AddTicks(6311)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "85135bd8-31c8-4267-8d55-3b3b245d6533"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "92274ba5-5bc8-4144-919c-b7ce649aa532"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 387, DateTimeKind.Local).AddTicks(2731)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6f7c4442-30e4-4d12-a18e-20bfb2960eb9"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4b052ca8-e4c5-4033-b4bf-90abccfcf24e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 377, DateTimeKind.Local).AddTicks(9695)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cccd22c8-940d-4a97-8736-8ebdff7c2b0e"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 391, DateTimeKind.Local).AddTicks(3396)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "IP verilmedi"),
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
                name: "PartnerCompanyTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Debt = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Receive = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    PartnerCompanyId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a87879cd-3abe-460b-87f6-92e96490d7c8"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 376, DateTimeKind.Local).AddTicks(8380)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7b7b1d8b-e7f4-4cd4-859c-fbf3e797b423"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1d426c03-abc4-4a53-a0c3-8fc41f925796"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 386, DateTimeKind.Local).AddTicks(2983)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "13bd2640-8cd9-43d5-ab0a-48525694ce30"),
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
                    ContractCount = table.Column<int>(type: "int", nullable: true),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaysWorked = table.Column<int>(type: "int", nullable: true),
                    CurrentPosition = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    ResidenceRegionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f073d4fc-12c6-43de-95c3-d05639c4f968"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 380, DateTimeKind.Local).AddTicks(812)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c7cc9243-bb54-4242-b5f3-ac2ef6ac8c9b"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "75c4da58-4a60-4433-b885-35927487e651"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 375, DateTimeKind.Local).AddTicks(1308)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4bca15e2-fb52-4570-ae5f-bef32a1ab002"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c25923aa-9db6-46a3-984a-3a62571ddbcc"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 375, DateTimeKind.Local).AddTicks(7826)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0a750d89-0db7-4eb2-8006-664529727e44"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1dd50b8d-e6d3-4a46-937a-2d9cb2d92d46"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 378, DateTimeKind.Local).AddTicks(7618)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "99e59d2e-f4d4-45a6-ab1e-095501f38012"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0647fda9-27d3-4fa2-90eb-949cecd86af3"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 379, DateTimeKind.Local).AddTicks(5105)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1a5cc952-05ec-4f77-9a63-2ede41b39fb2"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndContract = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 391, DateTimeKind.Local).AddTicks(8525))
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
                name: "PassEventTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "edd5e415-bac9-4fe7-a613-eff7734ff357"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 384, DateTimeKind.Local).AddTicks(7414)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c0ef5483-abee-4131-9397-93035e3ecffa"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CommissionRate = table.Column<byte>(type: "tinyint", nullable: false),
                    TotalCostwithCommission = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PartnerCompanyTransactionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassEventTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassEventTickets_PartnerCompanyTransactions_PartnerCompanyTransactionId",
                        column: x => x.PartnerCompanyTransactionId,
                        principalTable: "PartnerCompanyTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PassTourTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b69b4d8b-d900-47b3-acb3-6e4d2952496a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 385, DateTimeKind.Local).AddTicks(2744)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "288fe930-2970-48f7-9c4c-7e8a2822b642"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CommissionRate = table.Column<byte>(type: "tinyint", nullable: false),
                    TotalCostwithCommission = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PartnerCompanyTransactionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassTourTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassTourTickets_PartnerCompanyTransactions_PartnerCompanyTransactionId",
                        column: x => x.PartnerCompanyTransactionId,
                        principalTable: "PartnerCompanyTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventTicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "052a6160-e18e-44ca-b58f-70836798a78c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 383, DateTimeKind.Local).AddTicks(4672)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "681029f1-95f6-45dd-b9e7-1c33fea186a3"),
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
                    table.PrimaryKey("PK_EventTicketOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTicketOrders_AspNetUsers_WebUserAccountId",
                        column: x => x.WebUserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventTicketOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c5c56012-1ad2-4686-a3e5-2974c9db44e8"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 383, DateTimeKind.Local).AddTicks(8845)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0ed29365-f77f-41b7-878e-dbf9b6518c2f"),
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
                    table.PrimaryKey("PK_ProductOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOrders_AspNetUsers_WebUserAccountId",
                        column: x => x.WebUserAccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourTicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b6db8268-8b0e-4d95-8e76-04b8349bb304"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 384, DateTimeKind.Local).AddTicks(3182)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b0863706-a3c9-432c-92b6-5d2f86e7c75c"),
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
                name: "EventTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "53a7937f-a75b-4130-a57e-356ecb49ec77"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 387, DateTimeKind.Local).AddTicks(6446)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1f6b6df2-c03c-4c30-ba96-91e5d3ad321f"),
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
                    table.PrimaryKey("PK_EventTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTickets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3976ff22-e4f9-49ed-b6e1-ad45d0bc2a26"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 388, DateTimeKind.Local).AddTicks(3753)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2087acf8-65cf-421d-8145-c7c7ef6dcf5f"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "078451a7-6020-468e-b1aa-9954a1c2e27f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 388, DateTimeKind.Local).AddTicks(152)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "03e8d41f-da30-433f-b41f-2b252ee782d6"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d29423b3-e828-4819-b5d3-9a7b8c6ff00e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 388, DateTimeKind.Local).AddTicks(9752)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e32134e2-3520-422b-a803-d2d35c6dc5c5"),
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
                name: "ProductOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductOrderId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "da33c2ce-2a30-4df4-95df-a7ca5670d745"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 382, DateTimeKind.Local).AddTicks(4896)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9a16466f-de8f-47ba-a9aa-549a9227d4da"),
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
                    table.PrimaryKey("PK_ProductOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOrderDetails_ProductOrders_ProductOrderId",
                        column: x => x.ProductOrderId,
                        principalTable: "ProductOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductOrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventTicketOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTicketId = table.Column<int>(type: "int", nullable: true),
                    EventTicketOrderId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2be557e2-9710-4184-86bf-ec02a55943cf"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 382, DateTimeKind.Local).AddTicks(317)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b53e9814-df0f-4776-87b1-b7c3d507c86e"),
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
                    table.PrimaryKey("PK_EventTicketOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventTicketOrderDetails_EventTicketOrders_EventTicketOrderId",
                        column: x => x.EventTicketOrderId,
                        principalTable: "EventTicketOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventTicketOrderDetails_EventTickets_EventTicketId",
                        column: x => x.EventTicketId,
                        principalTable: "EventTickets",
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
                name: "TourTicketOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourTicketId = table.Column<int>(type: "int", nullable: true),
                    TourTicketOrderId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0d8ca37e-679b-463e-9271-849e0e1ae2fa"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 26, 4, 39, 28, 382, DateTimeKind.Local).AddTicks(9844)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0040877c-0869-4867-b728-74d08177da78"),
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
                    table.PrimaryKey("PK_TourTicketOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourTicketOrderDetail_TourTicketOrders_TourTicketOrderId",
                        column: x => x.TourTicketOrderId,
                        principalTable: "TourTicketOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TourTicketOrderDetail_TourTickets_TourTicketId",
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "Australia", "X 0", "CountryDescription 0", "CountryName 0", "Cphone 0", new DateTime(2002, 5, 23, 10, 39, 3, 0, DateTimeKind.Unspecified), "30b8305a-140e-44c4-83be-2152e99339ca", "CreatedIPAdress 0", "ff9904d2-8e38-43f1-9f0c-9f8709f885b8", "Active", null, null, null },
                    { 2, "Asia", "X 1", "CountryDescription 1", "CountryName 1", "Cphone 1", new DateTime(2016, 11, 9, 2, 18, 36, 0, DateTimeKind.Unspecified), "bd6fef1d-d59a-489c-85fa-db45be1a5dc1", "CreatedIPAdress 1", "e16090ce-4268-40db-bfc1-5c5c433446f3", "Passive", null, null, null },
                    { 3, "Africa", "X 2", "CountryDescription 2", "CountryName 2", "Cphone 2", new DateTime(2018, 3, 10, 23, 52, 33, 0, DateTimeKind.Unspecified), "299dd26e-4f3f-4ea6-adb7-bcde5b3cf833", "CreatedIPAdress 2", "99324bf2-4fbf-4c87-af31-c235e6fad73f", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "Australia", "X 3", "CountryDescription 3", "CountryName 3", "Cphone 3", new DateTime(2005, 4, 1, 16, 28, 41, 0, DateTimeKind.Unspecified), "298526df-e7fe-45b6-9098-3fa76c4c7b92", "CreatedIPAdress 3", "ccc27cae-4827-49c4-aabc-21575e03c642", null, null, null },
                    { 5, "NorthAmerica", "X 4", "CountryDescription 4", "CountryName 4", "Cphone 4", new DateTime(2020, 12, 12, 17, 18, 29, 0, DateTimeKind.Unspecified), "792e025b-c17f-44a9-b33f-59db2a16e0cf", "CreatedIPAdress 4", "5e1c80ac-fe3b-47ff-aac6-3c2e3ce276d2", null, null, null },
                    { 6, "None", "X 5", "CountryDescription 5", "CountryName 5", "Cphone 5", new DateTime(2001, 2, 16, 9, 50, 38, 0, DateTimeKind.Unspecified), "3a2970ba-5d62-457d-ba43-fdcedcef54a0", "CreatedIPAdress 5", "7e0e1015-352e-4162-8f9d-70cbce10cfbe", null, null, null },
                    { 7, "NorthAmerica", "X 6", "CountryDescription 6", "CountryName 6", "Cphone 6", new DateTime(2013, 5, 24, 3, 47, 28, 0, DateTimeKind.Unspecified), "b9324d88-3d37-4340-b717-7a1abfef2faa", "CreatedIPAdress 6", "ca58a458-a25b-4291-8a09-285683566490", null, null, null },
                    { 8, "NorthAmerica", "X 7", "CountryDescription 7", "CountryName 7", "Cphone 7", new DateTime(2013, 6, 16, 14, 43, 22, 0, DateTimeKind.Unspecified), "4f662fdf-bbd9-4d67-9e71-65caa5453db3", "CreatedIPAdress 7", "f410eec5-ff57-431b-839a-bc25786710bb", null, null, null },
                    { 9, "NorthAmerica", "X 8", "CountryDescription 8", "CountryName 8", "Cphone 8", new DateTime(2013, 1, 16, 11, 47, 26, 0, DateTimeKind.Unspecified), "22a01582-e733-4a52-875f-fcf043d0757a", "CreatedIPAdress 8", "5552897f-218e-44e4-8905-d473ea5aba7d", null, null, null },
                    { 10, "NorthAmerica", "X 9", "CountryDescription 9", "CountryName 9", "Cphone 9", new DateTime(2000, 11, 23, 13, 28, 38, 0, DateTimeKind.Unspecified), "54c38a20-56d3-4b2e-bab7-a25f04914312", "CreatedIPAdress 9", "6a0df0f5-ee9f-4409-8fa2-3effb130eedf", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 11, "Africa", "X 10", "CountryDescription 10", "CountryName 10", "Cphone 10", new DateTime(2013, 6, 3, 23, 42, 50, 0, DateTimeKind.Unspecified), "39739f1c-8e32-42dd-8266-b7c052b7aa73", "CreatedIPAdress 10", "26155b80-4a34-45f4-abb0-a922f98fc151", "Passive", null, null, null },
                    { 12, "Australia", "X 11", "CountryDescription 11", "CountryName 11", "Cphone 11", new DateTime(2014, 12, 16, 22, 19, 31, 0, DateTimeKind.Unspecified), "9ceede82-ba8d-4c6b-9d4f-dde32df8b233", "CreatedIPAdress 11", "3b7de206-ef11-49f3-bae3-7821c120d50e", "Active", null, null, null },
                    { 13, "Europe", "X 12", "CountryDescription 12", "CountryName 12", "Cphone 12", new DateTime(2021, 4, 24, 3, 12, 18, 0, DateTimeKind.Unspecified), "bc9bef29-69c1-4a64-8fa5-70f4b35bae38", "CreatedIPAdress 12", "b0efad4d-7249-401c-840b-81970d6eba04", "Active", null, null, null },
                    { 14, "NorthAmerica", "X 13", "CountryDescription 13", "CountryName 13", "Cphone 13", new DateTime(2003, 9, 16, 13, 26, 49, 0, DateTimeKind.Unspecified), "5326138d-1a07-4cd9-99e8-0a6968253b52", "CreatedIPAdress 13", "a216b16a-896e-4c32-8613-684836d7cb6c", "Active", null, null, null },
                    { 15, "Africa", "X 14", "CountryDescription 14", "CountryName 14", "Cphone 14", new DateTime(2002, 12, 15, 4, 27, 54, 0, DateTimeKind.Unspecified), "52c3fe13-8495-4219-9c3d-d4902101ba6f", "CreatedIPAdress 14", "82791ed4-bfb9-49e8-8681-0172dd386a96", "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "175d0a82-f5ee-46db-8c43-24ea296c3afc", 4, new DateTime(2007, 4, 10, 20, 44, 29, 0, DateTimeKind.Unspecified), "d8776844-4d3c-4875-9167-ad0b7dd5460b", "CreatedIPAdress 0", "Email 0", false, "43ba0b84-5a55-478e-b36b-9114203eff0b", false, null, "EMAİL 0", "USERNAME 0", "$2a$11$VFkIDHfJScqtdUlRPYfVvOe7auc5YDlchtQcgysbas1aVn75BAcPe", "PNumber 0", false, "5ea82d85-23f2-43f4-875d-acd30652f8f8", "Active", false, null, null, null, "UserName 0" },
                    { 2, 0, "17941a9a-a51c-411f-8121-c071ac024b2e", 5, new DateTime(2001, 3, 11, 17, 26, 36, 0, DateTimeKind.Unspecified), "328f3fc5-00e0-4cb8-bac5-d5ce04ad1d65", "CreatedIPAdress 1", "Email 1", false, "663b39fb-2e57-42a8-a5a4-d6dd9e60f7aa", false, null, "EMAİL 1", "USERNAME 1", "$2a$11$t4nm0fYMzxG0Pqa3pPttN.PN7gbhy2txi27tEAOaEnNXQQy33ScEW", "PNumber 1", false, "e65612b5-8244-475a-9c3a-49cbc6303921", "Active", false, null, null, null, "UserName 1" },
                    { 3, 0, "4bdd77a1-20e7-4ecc-99e3-a0e2075e8172", 1, new DateTime(2009, 9, 24, 13, 53, 5, 0, DateTimeKind.Unspecified), "ca11cd61-dece-4f86-80d0-f25a2b89a213", "CreatedIPAdress 2", "Email 2", false, "6ed4341d-1c0c-470a-bcc8-564e7f58b555", false, null, "EMAİL 2", "USERNAME 2", "$2a$11$JUikYvo.nXBvFVDXjNRR3ua.UJzikHsSnsw7tpKG.eNSwxcashsD2", "PNumber 2", false, "fa1ffc7b-8694-4948-8ef4-81e636612206", "Active", false, null, null, null, "UserName 2" },
                    { 4, 0, "f9cbc646-0209-4546-b12f-835d956089b5", 2, new DateTime(2006, 4, 9, 2, 23, 37, 0, DateTimeKind.Unspecified), "0e7beb06-7767-42ca-9f41-abe60f9d811a", "CreatedIPAdress 3", "Email 3", false, "639a0470-3db3-40d6-91aa-7fab12057f94", false, null, "EMAİL 3", "USERNAME 3", "$2a$11$qENvFRFGJFhQED7n7I33U.h.jsHwdY01EgEkuseIt6MHQiMVZ8D3O", "PNumber 3", false, "094083b3-bb54-4d8d-95db-ede168679b0a", "Passive", false, null, null, null, "UserName 3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 5, 0, "6314fbd4-cec5-4879-9a60-bf5818aa324f", 6, new DateTime(2013, 8, 13, 15, 34, 3, 0, DateTimeKind.Unspecified), "25ea0337-b7df-4e36-a141-2f433b80ef80", "CreatedIPAdress 4", "Email 4", false, "439ac808-589d-43d6-81ed-a9403de53ef1", false, null, "EMAİL 4", "USERNAME 4", "$2a$11$fcMurih.Vt.QnWGiuozqdeRHR/vLJXoKRRohnNPczubxJEgKVM5.m", "PNumber 4", false, "f31ddac2-33a4-4b36-803f-eeedfb817f59", false, null, null, null, "UserName 4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 6, 0, "6d57eb99-e0e6-47ae-8413-7c4ffa1562bd", 8, new DateTime(2021, 2, 10, 11, 38, 31, 0, DateTimeKind.Unspecified), "6d1a73f7-2f0d-44c6-a9f7-750b1dd7c213", "CreatedIPAdress 5", "Email 5", false, "d6c1bd01-7565-4028-b824-24091a121018", false, null, "EMAİL 5", "USERNAME 5", "$2a$11$tZj8s/j1Th9p7NWyEbIkS.X1UzEC5aeT.YCsYxe3mtESrBy/XNGWC", "PNumber 5", false, "74b75989-da5c-4f4d-82e1-3ae701a0685d", "Passive", false, null, null, null, "UserName 5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 7, 0, "511869b6-d6a4-438a-805a-b71b9408b178", 4, new DateTime(2014, 7, 25, 4, 17, 47, 0, DateTimeKind.Unspecified), "239db730-c52c-4479-9adf-7d229fbd4abc", "CreatedIPAdress 6", "Email 6", false, "dd8bde81-dffd-4098-b0cb-e5ebafc576b4", false, null, "EMAİL 6", "USERNAME 6", "$2a$11$BqhQ6tTrUJyMXTKx.yvV6OQl1qBu3ygZki.F9u0.85qRm.0oMRlxK", "PNumber 6", false, "eeafaffb-ea17-4db0-81b3-353041fedce1", false, null, null, null, "UserName 6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 8, 0, "a41df2aa-8aac-4bbc-8f2e-e03faff86748", 10, new DateTime(2007, 9, 16, 8, 57, 16, 0, DateTimeKind.Unspecified), "31a261de-8e9b-404d-8223-4deac1c25e49", "CreatedIPAdress 7", "Email 7", false, "48ff22b4-57e0-4cfd-b98f-1019c647eed2", false, null, "EMAİL 7", "USERNAME 7", "$2a$11$Rcb.xE/0Cc7uGq.zGpUM7uVsOFQ9aqXx2PlXlxK7VQo6M4/CnkOme", "PNumber 7", false, "d9659661-22f8-4f3c-a58b-7c33c451f051", "Active", false, null, null, null, "UserName 7" },
                    { 9, 0, "41150d06-38de-4ff9-83c4-980be23e1df5", 6, new DateTime(2020, 9, 6, 14, 54, 48, 0, DateTimeKind.Unspecified), "6240a421-3d67-4257-9ca6-d03a1df79c5e", "CreatedIPAdress 8", "Email 8", false, "9e9de176-9607-4979-a2db-4a7941fbd0c1", false, null, "EMAİL 8", "USERNAME 8", "$2a$11$wmaqumeW1XjFcDTv299GlOISGKSQVBS5lfRgYQyarUdeGwg.vj4JW", "PNumber 8", false, "29c8da50-1e40-4c6a-a8fa-bfbd5a8332c4", "Active", false, null, null, null, "UserName 8" },
                    { 10, 0, "b8a39d24-70f7-4d76-b6e7-ebdc0435338f", 10, new DateTime(2018, 12, 6, 12, 28, 31, 0, DateTimeKind.Unspecified), "89661828-3772-4f62-b04d-837180a2356f", "CreatedIPAdress 9", "Email 9", false, "f55d67f0-b063-4ee5-acf2-67ebcdaa8e86", false, null, "EMAİL 9", "USERNAME 9", "$2a$11$/NEQ1zs4w8P8NdKGmfqzreacS927kmEvGVzSWtUVNkzSO0vWIxnma", "PNumber 9", false, "079a9a27-de7b-48ab-a636-dc8a2faf0ec5", "Active", false, null, null, null, "UserName 9" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Adress 0", (byte)30, new DateTime(1994, 9, 23, 22, 8, 36, 0, DateTimeKind.Unspecified), 6, 2, new DateTime(2000, 6, 12, 2, 43, 7, 0, DateTimeKind.Unspecified), "132ee9b6-2bb0-48e6-8734-35575f484754", "CreatedIPAdress 0", "Marketing", 5987, "Email 0", new DateTime(2026, 11, 2, 23, 20, 45, 0, DateTimeKind.Unspecified), 2, "FirstName 0", "c6eac58a-ed7b-4210-a058-3c8b74b940e0", new DateTime(2008, 11, 2, 23, 20, 45, 0, DateTimeKind.Unspecified), "LastName 0", "PNumber 0", "PhotoPath 0", null, "TCN 0", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Adress 1", (byte)56, new DateTime(1969, 3, 20, 18, 29, 40, 0, DateTimeKind.Unspecified), 8, 4, new DateTime(2012, 9, 2, 5, 10, 49, 0, DateTimeKind.Unspecified), "c39b4b17-a352-4bac-80e8-38ae4fbb23da", "CreatedIPAdress 1", "Administrative", 7418, "Email 1", new DateTime(2028, 12, 3, 4, 14, 10, 0, DateTimeKind.Unspecified), 3, "FirstName 1", "Male", "fcf42990-4c20-4ecd-a63f-790082f21946", new DateTime(2004, 12, 3, 4, 14, 10, 0, DateTimeKind.Unspecified), "LastName 1", "PNumber 1", "PhotoPath 1", null, "TCN 1", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "Adress 2", (byte)52, new DateTime(1972, 8, 1, 20, 14, 47, 0, DateTimeKind.Unspecified), 4, 5, new DateTime(2021, 7, 26, 11, 23, 43, 0, DateTimeKind.Unspecified), "bef9010b-e7a6-4add-8bb0-7b0f50d27aa4", "CreatedIPAdress 2", "Administrative", 3362, "Email 2", new DateTime(2028, 1, 10, 13, 8, 49, 0, DateTimeKind.Unspecified), 4, "FirstName 2", "482f335a-20cf-4156-8bae-336ae62f0cf9", new DateTime(2016, 1, 10, 13, 8, 49, 0, DateTimeKind.Unspecified), "LastName 2", "PNumber 2", "PhotoPath 2", null, "TCN 2", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Adress 3", (byte)59, new DateTime(1965, 8, 11, 12, 50, 53, 0, DateTimeKind.Unspecified), 4, 7, new DateTime(2000, 11, 10, 10, 35, 12, 0, DateTimeKind.Unspecified), "37152d11-ccb4-4c22-8c5b-e61921d6f1e4", "CreatedIPAdress 3", "IT", 3912, "Email 3", new DateTime(2026, 7, 9, 12, 14, 33, 0, DateTimeKind.Unspecified), 5, "FirstName 3", "02ed7bf8-cdfd-47bc-a48f-30ce26681449", new DateTime(2014, 7, 9, 12, 14, 33, 0, DateTimeKind.Unspecified), "LastName 3", "PNumber 3", "PhotoPath 3", null, "Passive", "TCN 3", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Adress 4", (byte)57, new DateTime(1967, 4, 23, 23, 48, 3, 0, DateTimeKind.Unspecified), 6, 3, new DateTime(2004, 12, 21, 20, 37, 20, 0, DateTimeKind.Unspecified), "8b3a2a67-7770-4a2b-b303-18f9184e5cdd", "CreatedIPAdress 4", "Administrative", 6044, "Email 4", new DateTime(2026, 9, 6, 15, 27, 23, 0, DateTimeKind.Unspecified), 6, "FirstName 4", "Male", "1060f500-5ecc-4bbd-97a1-587f2a3377e6", new DateTime(2008, 9, 6, 15, 27, 23, 0, DateTimeKind.Unspecified), "LastName 4", "PNumber 4", "PhotoPath 4", null, "Active", "TCN 4", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 6, "Adress 5", (byte)58, new DateTime(1967, 1, 24, 18, 22, 10, 0, DateTimeKind.Unspecified), 4, 8, new DateTime(2015, 12, 9, 19, 14, 36, 0, DateTimeKind.Unspecified), "89e4ca11-472a-46f1-8f03-f236f5f41010", "CreatedIPAdress 5", "Marketing", 3600, "Email 5", new DateTime(2027, 5, 17, 11, 19, 50, 0, DateTimeKind.Unspecified), 7, "FirstName 5", "Female", "e0e5d83c-e72f-463a-97c9-166c5273f9a7", new DateTime(2015, 5, 17, 11, 19, 50, 0, DateTimeKind.Unspecified), "LastName 5", "PNumber 5", "PhotoPath 5", null, "TCN 5", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 7, "Adress 6", (byte)51, new DateTime(1973, 8, 9, 22, 16, 32, 0, DateTimeKind.Unspecified), 3, 4, new DateTime(2018, 3, 14, 10, 26, 51, 0, DateTimeKind.Unspecified), "7c758e99-c571-488b-be35-bffdb5670d91", "CreatedIPAdress 6", "Operations", 2997, "Email 6", new DateTime(2026, 1, 9, 12, 33, 13, 0, DateTimeKind.Unspecified), 8, "FirstName 6", "Male", "2101d0ab-3251-4c8c-8d76-5eecad2959fc", new DateTime(2017, 1, 9, 12, 33, 13, 0, DateTimeKind.Unspecified), "LastName 6", "PNumber 6", "PhotoPath 6", null, "Passive", "TCN 6", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 8, "Adress 7", (byte)64, new DateTime(1960, 8, 21, 10, 29, 24, 0, DateTimeKind.Unspecified), 9, 8, new DateTime(2018, 10, 22, 7, 10, 45, 0, DateTimeKind.Unspecified), "fc32ea57-f8c3-43da-9e58-108e81e85969", "CreatedIPAdress 7", "Accounting", 8710, "Email 7", new DateTime(2028, 5, 21, 3, 28, 43, 0, DateTimeKind.Unspecified), 9, "FirstName 7", "550eb782-1afe-41d7-9fa4-c863e87810af", new DateTime(2001, 5, 21, 3, 28, 43, 0, DateTimeKind.Unspecified), "LastName 7", "PNumber 7", "PhotoPath 7", null, "Passive", "TCN 7", null, null, null },
                    { 9, "Adress 8", (byte)57, new DateTime(1967, 9, 1, 4, 45, 34, 0, DateTimeKind.Unspecified), 5, 2, new DateTime(2010, 8, 5, 23, 33, 24, 0, DateTimeKind.Unspecified), "5c19988b-6385-4a6e-972a-9f70c4686d2a", "CreatedIPAdress 8", "IT", 4584, "Email 8", new DateTime(2027, 9, 5, 12, 30, 23, 0, DateTimeKind.Unspecified), 10, "FirstName 8", "ed28b428-71a9-4d6d-b5b1-9cd55b1eba74", new DateTime(2012, 9, 5, 12, 30, 23, 0, DateTimeKind.Unspecified), "LastName 8", "PNumber 8", "PhotoPath 8", null, "Active", "TCN 8", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 10, "Adress 9", (byte)31, new DateTime(1994, 2, 26, 6, 28, 6, 0, DateTimeKind.Unspecified), 2, 6, new DateTime(2004, 10, 10, 14, 25, 35, 0, DateTimeKind.Unspecified), "772ed110-08cb-4aae-ba92-29bc5c769b31", "CreatedIPAdress 9", "Consulting", 1906, "Email 9", new DateTime(2026, 1, 5, 9, 49, 23, 0, DateTimeKind.Unspecified), 11, "FirstName 9", "Female", "eddb7f52-0c4d-45f6-85bc-94cda3c1a4f4", new DateTime(2020, 1, 5, 9, 49, 23, 0, DateTimeKind.Unspecified), "LastName 9", "PNumber 9", "PhotoPath 9", null, "Active", "TCN 9", null, null, null },
                    { 11, "Adress 10", (byte)42, new DateTime(1982, 12, 9, 17, 16, 52, 0, DateTimeKind.Unspecified), 7, 10, new DateTime(2004, 2, 22, 18, 10, 28, 0, DateTimeKind.Unspecified), "b7b36f63-45cd-424d-afdf-d7ea3727271b", "CreatedIPAdress 10", "IT", 6697, "Email 10", new DateTime(2027, 11, 23, 7, 55, 38, 0, DateTimeKind.Unspecified), 12, "FirstName 10", "Male", "2f295fb9-d361-43c7-8e5f-7bcb44dfdb4e", new DateTime(2006, 11, 23, 7, 55, 38, 0, DateTimeKind.Unspecified), "LastName 10", "PNumber 10", "PhotoPath 10", null, "Active", "TCN 10", null, null, null },
                    { 12, "Adress 11", (byte)55, new DateTime(1969, 7, 23, 5, 42, 33, 0, DateTimeKind.Unspecified), 4, 8, new DateTime(2006, 7, 16, 14, 52, 26, 0, DateTimeKind.Unspecified), "a19795d9-7fbf-4790-81c7-e4597da2ea19", "CreatedIPAdress 11", "Operations", 3172, "Email 11", new DateTime(2028, 7, 18, 5, 47, 5, 0, DateTimeKind.Unspecified), 13, "FirstName 11", "Female", "65f34fb4-b275-40f3-8c45-1d5eda7e9e2d", new DateTime(2016, 7, 18, 5, 47, 5, 0, DateTimeKind.Unspecified), "LastName 11", "PNumber 11", "PhotoPath 11", null, "Passive", "TCN 11", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 13, "Adress 12", (byte)37, new DateTime(1987, 9, 8, 12, 29, 7, 0, DateTimeKind.Unspecified), 2, 8, new DateTime(2019, 1, 21, 18, 8, 37, 0, DateTimeKind.Unspecified), "9c0458eb-6873-4a10-b2e4-87993ebf322a", "CreatedIPAdress 12", "Operations", 1842, "Email 12", new DateTime(2026, 3, 9, 13, 58, 46, 0, DateTimeKind.Unspecified), 14, "FirstName 12", "b2254a52-fe65-4f47-98d4-f5cbf1b54dfd", new DateTime(2020, 3, 9, 13, 58, 46, 0, DateTimeKind.Unspecified), "LastName 12", "PNumber 12", "PhotoPath 12", null, "Active", "TCN 12", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 14, "Adress 13", (byte)38, new DateTime(1986, 5, 15, 4, 54, 22, 0, DateTimeKind.Unspecified), 9, 9, new DateTime(2015, 3, 2, 7, 52, 28, 0, DateTimeKind.Unspecified), "a0c47f71-50d3-4769-af56-b5529a8b049f", "CreatedIPAdress 13", "Marketing", 8528, "Email 13", new DateTime(2028, 11, 18, 10, 55, 39, 0, DateTimeKind.Unspecified), 15, "FirstName 13", "Female", "850a19b7-0016-4a4d-86df-4580df98623d", new DateTime(2001, 11, 18, 10, 55, 39, 0, DateTimeKind.Unspecified), "LastName 13", "PNumber 13", "PhotoPath 13", null, "TCN 13", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 15, "Adress 14", (byte)37, new DateTime(1987, 6, 10, 20, 14, 34, 0, DateTimeKind.Unspecified), 8, 2, new DateTime(2009, 6, 17, 9, 46, 52, 0, DateTimeKind.Unspecified), "24967eff-927c-4ad9-9636-c75258b7c60b", "CreatedIPAdress 14", "Operations", 7579, "Email 14", new DateTime(2028, 6, 24, 9, 38, 31, 0, DateTimeKind.Unspecified), 16, "FirstName 14", "Female", "462224e5-8159-4894-93e6-67496483a1fd", new DateTime(2004, 6, 24, 9, 38, 31, 0, DateTimeKind.Unspecified), "LastName 14", "PNumber 14", "PhotoPath 14", null, "Passive", "TCN 14", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Adress 0", (byte)33, new DateTime(1991, 9, 15, 9, 17, 3, 0, DateTimeKind.Unspecified), "Email 0", "FirstName 0", "Male", "LastName 0", "PNumber 0", "PhotoPath 0", "TCN 0", new DateTime(2007, 4, 2, 10, 27, 3, 0, DateTimeKind.Unspecified) },
                    { 2, "Adress 1", (byte)54, new DateTime(1970, 6, 12, 4, 46, 35, 0, DateTimeKind.Unspecified), "Email 1", "FirstName 1", "Male", "LastName 1", "PNumber 1", "PhotoPath 1", "TCN 1", new DateTime(2010, 8, 6, 7, 44, 26, 0, DateTimeKind.Unspecified) },
                    { 3, "Adress 2", (byte)34, new DateTime(1990, 11, 4, 14, 10, 27, 0, DateTimeKind.Unspecified), "Email 2", "FirstName 2", "Male", "LastName 2", "PNumber 2", "PhotoPath 2", "TCN 2", new DateTime(2014, 6, 19, 2, 36, 20, 0, DateTimeKind.Unspecified) },
                    { 4, "Adress 3", (byte)32, new DateTime(1992, 5, 2, 16, 26, 34, 0, DateTimeKind.Unspecified), "Email 3", "FirstName 3", "Male", "LastName 3", "PNumber 3", "PhotoPath 3", "TCN 3", new DateTime(2021, 11, 4, 4, 55, 39, 0, DateTimeKind.Unspecified) },
                    { 5, "Adress 4", (byte)51, new DateTime(1973, 9, 8, 17, 49, 48, 0, DateTimeKind.Unspecified), "Email 4", "FirstName 4", "Male", "LastName 4", "PNumber 4", "PhotoPath 4", "TCN 4", new DateTime(2010, 12, 2, 3, 8, 34, 0, DateTimeKind.Unspecified) },
                    { 6, "Adress 5", (byte)45, new DateTime(1979, 9, 6, 3, 48, 25, 0, DateTimeKind.Unspecified), "Email 5", "FirstName 5", "Female", "LastName 5", "PNumber 5", "PhotoPath 5", "TCN 5", new DateTime(2019, 7, 4, 9, 12, 15, 0, DateTimeKind.Unspecified) },
                    { 7, "Adress 6", (byte)24, new DateTime(2001, 3, 14, 16, 35, 5, 0, DateTimeKind.Unspecified), "Email 6", "FirstName 6", "Female", "LastName 6", "PNumber 6", "PhotoPath 6", "TCN 6", new DateTime(2014, 1, 24, 4, 25, 36, 0, DateTimeKind.Unspecified) },
                    { 8, "Adress 7", (byte)58, new DateTime(1966, 8, 9, 2, 26, 2, 0, DateTimeKind.Unspecified), "Email 7", "FirstName 7", "Male", "LastName 7", "PNumber 7", "PhotoPath 7", "TCN 7", new DateTime(2016, 6, 16, 4, 50, 16, 0, DateTimeKind.Unspecified) }
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
                name: "IX_EventTicketOrderDetails_EventTicketId",
                table: "EventTicketOrderDetails",
                column: "EventTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTicketOrderDetails_EventTicketOrderId",
                table: "EventTicketOrderDetails",
                column: "EventTicketOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTicketOrders_EmployeeId",
                table: "EventTicketOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTicketOrders_WebUserAccountId",
                table: "EventTicketOrders",
                column: "WebUserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTickets_EventId",
                table: "EventTickets",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerCompanyTransactions_PartnerCompanyId",
                table: "PartnerCompanyTransactions",
                column: "PartnerCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PassEventTickets_PartnerCompanyTransactionId",
                table: "PassEventTickets",
                column: "PartnerCompanyTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_PassTourTickets_PartnerCompanyTransactionId",
                table: "PassTourTickets",
                column: "PartnerCompanyTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrderDetails_ProductId",
                table: "ProductOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrderDetails_ProductOrderId",
                table: "ProductOrderDetails",
                column: "ProductOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_EmployeeId",
                table: "ProductOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_WebUserAccountId",
                table: "ProductOrders",
                column: "WebUserAccountId");

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
                name: "IX_TourTicketOrderDetail_TourTicketId",
                table: "TourTicketOrderDetail",
                column: "TourTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TourTicketOrderDetail_TourTicketOrderId",
                table: "TourTicketOrderDetail",
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
                name: "EventTicketOrderDetails");

            migrationBuilder.DropTable(
                name: "PassEventTickets");

            migrationBuilder.DropTable(
                name: "PassTourTickets");

            migrationBuilder.DropTable(
                name: "ProductOrderDetails");

            migrationBuilder.DropTable(
                name: "TourTicketOrderDetail");

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
                name: "EventTicketOrders");

            migrationBuilder.DropTable(
                name: "EventTickets");

            migrationBuilder.DropTable(
                name: "PartnerCompanyTransactions");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "TourTicketOrders");

            migrationBuilder.DropTable(
                name: "TourTickets");

            migrationBuilder.DropTable(
                name: "RentalVehicleSuppliers");

            migrationBuilder.DropTable(
                name: "SubContractWorkerSuppliers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "PartnerCompanies");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductSuppliers");

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
