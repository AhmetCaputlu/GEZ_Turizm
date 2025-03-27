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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "625f7217-97e1-4e38-9c6b-6e49d0860fdf"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 365, DateTimeKind.Local).AddTicks(6790)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7d5e1562-791e-4007-8dd2-7568d8865872"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3ed514dd-7e92-4edf-aa0c-e8065e58f433"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 363, DateTimeKind.Local).AddTicks(7310)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "de7cc399-7790-4753-a119-fe524eb6e4bf"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2bf1669f-f3a0-491a-ab49-0928e3218ceb"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 373, DateTimeKind.Local).AddTicks(7436)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "006a5b8d-f176-4ea3-8f58-0269e1d2e2fc"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8501d8ba-454d-46a3-b07d-39a7603fae94"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 364, DateTimeKind.Local).AddTicks(4019)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "16f556d1-2701-4647-b54a-63246a6b899d"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "53856c34-8dd7-49d7-a552-d62a1a15077e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 364, DateTimeKind.Local).AddTicks(7741)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3c4951f2-7c76-4705-9cd0-73e28543e8f3"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3003cc13-46f4-4ec8-998b-977c405978b5"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 374, DateTimeKind.Local).AddTicks(6328)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4538dd87-3a9f-48a7-8ad9-d55bdbfa2940"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "49a97c0a-58b6-41a3-b3e8-95250bc5ff86"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 374, DateTimeKind.Local).AddTicks(9346)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b4d7cb7a-c015-418f-b5f6-250596cde03d"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "eaf75c32-bac9-4002-ae28-fdcade9ac6e5"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 365, DateTimeKind.Local).AddTicks(1538)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1624f80d-3251-4b8e-9971-c834c3ddbb30"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 378, DateTimeKind.Local).AddTicks(8227)),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f773ddcb-2a85-4324-bf10-63d52a242637"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 364, DateTimeKind.Local).AddTicks(1291)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "93929db2-9c1b-4616-acda-bf158494cf63"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1a1cdbf0-b430-4c42-88a5-525aa451cdaa"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 374, DateTimeKind.Local).AddTicks(2998)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5cc32e77-9618-4411-a3d3-0de84579db85"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7a619f74-454b-4636-8c1a-84d549ba9bb9"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 367, DateTimeKind.Local).AddTicks(3271)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b1ec0eae-1b2d-4edf-a48c-a990a479975a"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "304b2e9f-bb73-4cfb-8bfd-8783073eb43e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 362, DateTimeKind.Local).AddTicks(3673)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a5f8ce03-a25e-4ee7-9784-696bb0c27b27"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "aee2ec43-c965-49de-98b1-506b46649999"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 363, DateTimeKind.Local).AddTicks(109)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4848d89f-4c9f-45e5-b086-99b7eb2e60dc"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "bd635d1a-94c5-471b-bb46-2599b011ac87"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 366, DateTimeKind.Local).AddTicks(545)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b49c6dd6-0663-4963-8d33-a3e36c21cc11"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "bb6877cd-1649-444d-9375-718b6cef5a96"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 366, DateTimeKind.Local).AddTicks(7389)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7289c8d4-5ca0-4c3e-9dad-b97834fe768f"),
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
                    PhoneNumber = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 379, DateTimeKind.Local).AddTicks(3484))
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fe16f5ee-8942-4a41-920c-52c7a68f91b1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 372, DateTimeKind.Local).AddTicks(7468)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e9722c50-2629-48a2-8ee3-dc7869354d98"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "84f5994b-2b21-43f9-b2bf-b217ff7468c2"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 373, DateTimeKind.Local).AddTicks(2320)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e2b88da0-f3e6-4007-b42a-a0950aa0af39"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7c5fee66-f0cb-4a8e-9dd0-a42ffa305057"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 370, DateTimeKind.Local).AddTicks(6513)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a75e2ee9-bc8c-43d8-97d5-d0efdfdc81e8"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fb713eb2-b90c-4026-ae86-d37ecf521910"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 371, DateTimeKind.Local).AddTicks(857)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "034abaea-1de1-45c7-8dc3-c01cbbd4dfcb"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "975636f3-4a02-4d5a-8ef8-7cb2e6095c8f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 372, DateTimeKind.Local).AddTicks(2915)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "749bc40e-0342-42f8-8303-1871375405e9"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "27ddad58-d3e9-4656-b7dc-a1b4a6efde45"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 375, DateTimeKind.Local).AddTicks(2612)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "479599fd-c27b-4f6e-ac9b-84f7aab2731d"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fe112d60-3114-4aa0-8b4c-37d1f1a06793"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 376, DateTimeKind.Local).AddTicks(153)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "856a1b90-793c-470a-9100-8b61bb8c2a90"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e35dd0eb-86fb-48e3-b641-ab41c1a5e9f2"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 375, DateTimeKind.Local).AddTicks(6743)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "17107a1e-a0f8-4473-ab00-1e3882815f18"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "57155346-68d2-48cf-b167-3ad165d6e4b7"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 376, DateTimeKind.Local).AddTicks(5256)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "85174216-fd8f-49ed-8d4e-e14c7204b728"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "abe9e24c-6fb9-4704-b000-4cbf8a84c6b2"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 369, DateTimeKind.Local).AddTicks(7352)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cb701d33-efd5-4965-8eeb-3e60cc50df06"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "47a79676-b885-4b9a-86b1-808e68513c68"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 369, DateTimeKind.Local).AddTicks(2143)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a091b24e-2b2e-4e78-8ec8-20a26d95e688"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5c1e73f6-db88-452f-bf3a-010a28f6189c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 28, 1, 7, 13, 370, DateTimeKind.Local).AddTicks(1950)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3712b204-3c60-4a8e-a923-c46413ae5041"),
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
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Scotland", (byte)40, new DateTime(1984, 9, 22, 9, 41, 35, 0, DateTimeKind.Unspecified), new DateTime(2008, 4, 9, 3, 36, 12, 0, DateTimeKind.Unspecified), "28ea05c4-d45a-44f6-8c59-f371431f4371", "247.89.244.232", "D", "Samir_Terry34@hotmail.com", new DateTime(2016, 3, 12, 12, 57, 9, 0, DateTimeKind.Unspecified), 3, "Marie", "Male", "a1a97ddb-36d4-4743-8b59-f34a79b7e407", new DateTime(2015, 3, 12, 12, 57, 9, 0, DateTimeKind.Unspecified), "Schneider", "05986425654", "https://zachary.biz/bulgarian-lev", null, "13257757633", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "England", (byte)60, new DateTime(1964, 6, 4, 6, 49, 47, 0, DateTimeKind.Unspecified), new DateTime(2015, 10, 15, 22, 40, 7, 0, DateTimeKind.Unspecified), "e2f311de-3bf8-401d-8e95-5d65781abbae", "142.133.42.98", "Maximus_Bayer71@yahoo.com", new DateTime(2020, 7, 4, 12, 49, 39, 0, DateTimeKind.Unspecified), 4, "Lisa", "1c8a1047-db20-46f1-9fc9-338fd4f78d3e", new DateTime(2019, 7, 4, 12, 49, 39, 0, DateTimeKind.Unspecified), "Corwin", "05764721339", "http://maye.biz/technician/driver", "Active", null, "94399738429", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "England", (byte)37, new DateTime(1988, 2, 4, 10, 39, 48, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 3, 3, 13, 4, 0, DateTimeKind.Unspecified), "69c7bef3-abd9-498d-8b78-ec9327ae4f6a", "179.72.18.128", "Aurore.Rolfson94@hotmail.com", new DateTime(2020, 4, 3, 4, 11, 6, 0, DateTimeKind.Unspecified), 1, "Marlin", "Male", "7461f845-e967-4923-9df6-a114b695b700", new DateTime(2019, 4, 3, 4, 11, 6, 0, DateTimeKind.Unspecified), "Reilly", "05534566463", "http://ılene.name/legacy", "Active", null, "51094631716", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Wales", (byte)50, new DateTime(1974, 5, 8, 14, 20, 18, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 3, 8, 38, 45, 0, DateTimeKind.Unspecified), "784cebb4-770a-4e0c-b548-42cfd0f0f0da", "159.176.170.222", "ADB", "Carolanne_Koelpin67@hotmail.com", new DateTime(2021, 1, 9, 9, 59, 11, 0, DateTimeKind.Unspecified), 2, "Henderson", "Female", "c91437d0-c37f-4412-8dec-4d30f35905dc", new DateTime(2020, 1, 9, 9, 59, 11, 0, DateTimeKind.Unspecified), "Walker", "05912558102", "http://colt.biz/digital/borders/yellow", "Passive", null, "79117457175", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Northern Ireland", (byte)49, new DateTime(1975, 12, 24, 13, 14, 33, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 25, 22, 23, 15, 0, DateTimeKind.Unspecified), "ec15602c-8839-467c-a2cd-d951a121ffca", "157.211.16.55", "Janice.Gulgowski@hotmail.com", new DateTime(2022, 7, 5, 17, 57, 36, 0, DateTimeKind.Unspecified), 4, "Leila", "092d7667-4cf2-4f8f-a183-8c294a5b51e8", new DateTime(2021, 7, 5, 17, 57, 36, 0, DateTimeKind.Unspecified), "Rau", "05380956763", "https://margaret.org/interface/smtp/infomediaries", "Active", null, "30276669975", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Wales", (byte)56, new DateTime(1969, 1, 22, 14, 51, 7, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 23, 23, 41, 44, 0, DateTimeKind.Unspecified), "0e31b7af-3b3f-4ae3-9ccf-dee8b3a435be", "179.77.2.3", "Sammy_Schneider@yahoo.com", new DateTime(2013, 1, 20, 11, 52, 13, 0, DateTimeKind.Unspecified), 4, "Emilie", "c709fe52-1637-4828-a3c8-70f776aed698", new DateTime(2012, 1, 20, 11, 52, 13, 0, DateTimeKind.Unspecified), "Italian", "Reichel", "05598786207", "https://tate.com/product/mint-green", "Active", null, "93273339103", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Scotland", (byte)30, new DateTime(1994, 5, 22, 13, 43, 6, 0, DateTimeKind.Unspecified), new DateTime(2001, 2, 19, 14, 28, 48, 0, DateTimeKind.Unspecified), "03bdff4c-afe9-4fa0-b5c0-e53a7662eec3", "39.245.85.16", "Jaylen_Tromp56@gmail.com", new DateTime(2004, 3, 13, 18, 54, 10, 0, DateTimeKind.Unspecified), 3, "Miracle", "Male", "f316b20f-aa53-4f0e-9125-9ad89a4f0404", new DateTime(2003, 3, 13, 18, 54, 10, 0, DateTimeKind.Unspecified), "Harvey", "05518685104", "http://cristal.info/new-taiwan-dollar/frozen", "Active", null, "34994497000", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "Language", "LastName", "PhoneNumber", "PhotoPath", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "Scotland", (byte)38, new DateTime(1986, 12, 10, 3, 34, 23, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 22, 12, 12, 36, 0, DateTimeKind.Unspecified), "71f383b5-f206-43f1-a2e2-513a45935499", "176.210.14.126", "Abdul.Grady22@gmail.com", new DateTime(2001, 6, 5, 21, 12, 50, 0, DateTimeKind.Unspecified), 4, "Camryn", "Female", "a2fa795d-b13b-4ced-b46b-b61b276ff1ce", new DateTime(2000, 6, 5, 21, 12, 50, 0, DateTimeKind.Unspecified), "German", "Hayes", "05411950261", "https://mollie.org/assistant/supervisor/granite", null, "33931129288", null, null, null },
                    { 4, "England", (byte)63, new DateTime(1962, 2, 8, 3, 10, 9, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 1, 17, 19, 21, 0, DateTimeKind.Unspecified), "bdc0564d-2171-4f43-b028-c92997e50c90", "61.165.210.126", "Karen_Stroman@yahoo.com", new DateTime(2019, 12, 2, 21, 25, 41, 0, DateTimeKind.Unspecified), 1, "Clementina", "Female", "15bdae09-9eff-4561-a3e6-0a4edc6562dd", new DateTime(2018, 12, 2, 21, 25, 41, 0, DateTimeKind.Unspecified), "German", "Graham", "05584022997", "https://bryon.biz/legacy", null, "09019476487", null, null, null },
                    { 5, "England", (byte)55, new DateTime(1969, 4, 14, 11, 31, 39, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 2, 19, 50, 39, 0, DateTimeKind.Unspecified), "64e29ad7-96c1-4d4c-86ce-09e2f697004d", "107.111.13.244", "Precious69@gmail.com", new DateTime(2016, 3, 20, 16, 25, 49, 0, DateTimeKind.Unspecified), 2, "Maddison", "Female", "968f5def-d1dc-464c-bdc8-d2dafa27b027", new DateTime(2015, 3, 20, 16, 25, 49, 0, DateTimeKind.Unspecified), "French", "Cormier", "05557190707", "https://heidi.org/ınvestor", null, "73464024550", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Africa", "TR", "Cum eum vitae non ducimus doloribus.", "Turkey", "+90", new DateTime(2011, 3, 27, 15, 34, 28, 0, DateTimeKind.Unspecified), "6d506407-bc2c-4156-a903-896ac2426772", "74.51.9.230", "bbb86a75-8219-4e95-97c6-5afbf60e2a10", null, null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "Africa", "RU", "Voluptatem et corporis quos ut laborum.", "Russia", "+7", new DateTime(2004, 6, 26, 10, 14, 42, 0, DateTimeKind.Unspecified), "edca34f2-08bf-4890-9188-13a51f32428d", "243.192.104.144", "bd462417-dcbc-4853-9281-60105dc74b2f", "Active", null, null, null },
                    { 3, "Europe", "USA", "Fuga adipisci atque earum non provident.", "United States of America", "+1", new DateTime(2006, 6, 15, 21, 40, 44, 0, DateTimeKind.Unspecified), "a9ad34b1-1672-42ae-8d57-ff78693ad25d", "66.149.19.182", "0b4f234f-eef6-4061-a428-4932ba379767", "Passive", null, null, null },
                    { 4, "SouthAmerica", "SA", "Eaque ipsam autem optio harum doloribus.", "Kingdom of Saudi Arabia", "+966", new DateTime(2002, 9, 6, 16, 50, 25, 0, DateTimeKind.Unspecified), "f6d7f665-c6aa-42a7-8717-27c6ed6ae8f4", "55.166.55.175", "624d6b94-75ae-4a5e-b58b-a2758d75f206", "Active", null, null, null },
                    { 5, "Africa", "GER", "Debitis voluptates voluptatem impedit beatae velit.", "Germany", "+49", new DateTime(2000, 10, 16, 20, 23, 25, 0, DateTimeKind.Unspecified), "e4919865-c6ea-40eb-a70a-c81419ad7d8a", "145.20.7.133", "9c199116-30bb-4b29-bba4-70e109ba97ef", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ResidenceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "Status", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 2, 31, 0, 0), new DateTime(2004, 5, 8, 22, 43, 12, 0, DateTimeKind.Unspecified), "2dff296a-fe95-4e41-befe-cc2a7cf194e8", "97.19.107.247", "tempore", "4208495a-e001-4796-9ca0-b82bcef16bca", "Active", "Yacht", null, null, null },
                    { 2, new TimeSpan(0, 1, 25, 0, 0), new DateTime(2015, 5, 10, 21, 46, 26, 0, DateTimeKind.Unspecified), "ed3d0926-c699-403e-800a-d517e075d08c", "180.97.214.180", "doloribus", "d1cd9d9e-e05a-4370-ba71-047c0ff1624d", "Passive", "Motorbike", null, null, null },
                    { 3, new TimeSpan(0, 2, 14, 0, 0), new DateTime(2011, 3, 16, 13, 15, 29, 0, DateTimeKind.Unspecified), "a7c44378-66a7-4980-a77f-d07a9bf52f99", "71.107.176.21", "iste", "e752dd05-f274-44bd-aa4c-fc4c4b23ebc0", "Passive", "Minibus", null, null, null },
                    { 4, new TimeSpan(0, 1, 4, 0, 0), new DateTime(2007, 3, 17, 5, 45, 38, 0, DateTimeKind.Unspecified), "16e5f1a6-c2a1-454f-b0b8-589b7a863029", "73.164.122.193", "cupiditate", "007c57ac-8cfe-43a3-84ac-3b19f0a89c54", "Passive", "Yacht", null, null, null },
                    { 5, new TimeSpan(0, 0, 56, 0, 0), new DateTime(2001, 5, 6, 20, 24, 38, 0, DateTimeKind.Unspecified), "38f3e7aa-d499-4d08-b6e3-cae3502296a5", "90.225.127.107", "non", "8da07567-e1a5-470c-ae23-298dc1e4e41c", "Passive", "Jeep", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "01cb00a0-bd67-4af1-b8f6-67398af28745", 2, new DateTime(2005, 7, 13, 7, 15, 26, 0, DateTimeKind.Unspecified), "06abaefc-06b5-452b-b8f0-7306788af73f", "206.117.144.222", "Michele.Bashirian75@gmail.com", false, "86e759fb-737e-47d5-9a57-11d7b23d027d", false, null, "MİCHELE.BASHİRİAN75@GMAİL.COM", "TONY", "$2a$11$hbVm6wUQW7kVI9bM0ooBK.OIM4Gs0lvdKXrmXu/oX39Xso1hXMU92", "05676567091", false, "9e2c0d20-955c-420f-aa3e-51c18bdd843d", "Active", false, null, null, null, "Tony" },
                    { 2, 0, "0b82b823-571a-4fdb-b7bd-4c6caba5c06c", 2, new DateTime(2011, 10, 3, 11, 35, 28, 0, DateTimeKind.Unspecified), "311b8b40-204a-4be4-8bf7-c1f33fd6736a", "160.129.255.140", "Bertrand_Nicolas81@hotmail.com", false, "fb58bb4f-c09b-4ec1-a87e-840b974a42be", false, null, "BERTRAND_NİCOLAS81@HOTMAİL.COM", "TAUREAN", "$2a$11$jbTgE./zX9NP8qAnicq4T.RJc1PeoQLkKFuSz9oFxE0w.11tq0dOe", "05969089029", false, "27b645db-c607-44b1-a09d-9106fe8157b9", "Active", false, null, null, null, "Taurean" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 3, 0, "7c3c09db-04f4-4ea6-8860-a6c6236c4057", 5, new DateTime(2015, 12, 27, 12, 13, 25, 0, DateTimeKind.Unspecified), "f06d21d8-fbb7-4912-a390-4dc0c4456f35", "180.203.49.91", "Dedrick92@gmail.com", false, "ca57533b-3b58-4dbf-b6ec-b26dc54dd2c0", false, null, "DEDRİCK92@GMAİL.COM", "NANNİE", "$2a$11$74Fn9OuREXukjVUqruYwWe6H.Z2Z/dSNdfmKjKPX7EZ3HDjCt/kKS", "05179929362", false, "1c79ba0a-4d1b-4fd4-a8a7-232e2cb7be8b", false, null, null, null, "Nannie" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "634d0fad-4567-4c56-9972-b4c7e9ca7993", 1, new DateTime(2002, 1, 6, 12, 24, 24, 0, DateTimeKind.Unspecified), "8425cd90-6ac0-47f9-9c34-3c3f8aab7833", "137.56.74.77", "Aylin0@hotmail.com", false, "68c400b0-c21d-4741-a432-0c7f8a95ddbc", false, null, "AYLİN0@HOTMAİL.COM", "MİLAN", "$2a$11$gHDx2TVVUTS7w7gUHjIY0.10drz43vIQLZSRJJGjCWmZkLyr2IyH.", "05943769801", false, "28756d07-e5cf-489c-a8a4-ecf109ed3da3", "Passive", false, null, null, null, "Milan" },
                    { 5, 0, "3c14ff21-3ba4-4d01-96e7-2d148a0a3e22", 4, new DateTime(2009, 3, 8, 21, 21, 16, 0, DateTimeKind.Unspecified), "c0bda293-ae98-47f5-a936-694f23cbf5dc", "11.5.171.92", "Kasey49@hotmail.com", false, "19d0487c-3660-406d-94e4-183f205ae069", false, null, "KASEY49@HOTMAİL.COM", "GABRİEL", "$2a$11$Xc1LUJO4nxABBTTOT3MMPOlwtdq1TXAfbQrVupFGQ.1QS..7aq1MW", "05693538189", false, "6d2a7f1f-df88-4e7e-8e06-b68f12f8d9d1", "Passive", false, null, null, null, "Gabriel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 6, 0, "61f08c7a-93eb-4e0e-8ee9-0969dde7b9a4", 1, new DateTime(2012, 10, 15, 20, 26, 13, 0, DateTimeKind.Unspecified), "bf6e0f31-3516-429d-b830-e599917cab9c", "69.75.118.180", "Amiya7@yahoo.com", false, "3940cd47-39d3-4e36-a3c7-99517da2eeef", false, null, "AMİYA7@YAHOO.COM", "MUSTAFA", "$2a$11$2zCnCpt.u15Id/Mpp414t.8ClFb3Ry3FbO3By2D4SASFs2p7Svs.O", "05149944993", false, "97ae7095-d3bd-46f8-9fad-6113569aa8c0", false, null, null, null, "Mustafa" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 7, 0, "705af524-3cec-4435-b5c6-ac36b75f3cb6", 3, new DateTime(2007, 7, 9, 22, 58, 18, 0, DateTimeKind.Unspecified), "20d9d9c4-e547-45c9-813c-912a0f4a6947", "155.159.70.236", "Stella.Raynor@yahoo.com", false, "5230fe99-0927-45eb-82dc-67f604d34719", false, null, "STELLA.RAYNOR@YAHOO.COM", "PATRİCİA", "$2a$11$Zfm79xV8GH.08KBozxNhGuZr/rc34A9HneLpnLxcdYmrgKhZ/Cd0e", "05201890237", false, "1619ce28-aaa9-412b-8250-0cf8d12e087b", "Active", false, null, null, null, "Patricia" },
                    { 8, 0, "d01e75bf-7672-41cb-ab5a-4b91142ee591", 2, new DateTime(2006, 12, 4, 10, 20, 28, 0, DateTimeKind.Unspecified), "65d9ad48-9010-428a-8059-2b69317b3b3c", "41.113.118.219", "Daphney_Roob@hotmail.com", false, "1cbe7a1d-be51-4865-a549-d94129278fb1", false, null, "DAPHNEY_ROOB@HOTMAİL.COM", "DALE", "$2a$11$usSLbuZ4mGjVnibYXAvtpehGwL6i8VV.1GLnLopZ9EQBEwjJIp/Re", "05505480820", false, "bc0deb1d-769f-4911-9a7b-21f7c51104dd", "Active", false, null, null, null, "Dale" },
                    { 9, 0, "7849eb3c-9331-4d23-9f0d-7d7ae9b86b0e", 4, new DateTime(2017, 10, 20, 5, 44, 24, 0, DateTimeKind.Unspecified), "339008e1-ad78-4b0c-9301-890dfec4c255", "229.130.178.109", "Jaeden38@hotmail.com", false, "e2f65da2-99f5-43f3-b50d-a2cd9b82c8c1", false, null, "JAEDEN38@HOTMAİL.COM", "KRAİG", "$2a$11$p10FgyhIkUOzAxn4iY13nu6A4BzVVO8g5.LtSLNiGqandpR4sFfbm", "05255644003", false, "7a7b5df7-1728-45d3-b8ef-2ce99b3add0c", "Passive", false, null, null, null, "Kraig" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 10, 0, "2ff57c28-036c-4fcb-985b-553a2678e854", 1, new DateTime(2007, 3, 12, 4, 18, 13, 0, DateTimeKind.Unspecified), "20f82783-dae2-49b8-b5db-3df5b463f26d", "77.57.212.247", "Kobe21@yahoo.com", false, "69d83a05-977d-4d0e-9795-65369ba47816", false, null, "KOBE21@YAHOO.COM", "VİDA", "$2a$11$aEL7rI7Bv9hEc3jZMQ6YNOq8ZHUraumSKhByYO3/VYwjs7pMetMWC", "05547858708", false, "87726ddb-7a5e-4396-a074-01bb00a5f6ff", false, null, null, null, "Vida" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Northern Ireland", (byte)53, new DateTime(1971, 12, 27, 2, 35, 50, 0, DateTimeKind.Unspecified), 7, 1, new DateTime(2008, 3, 1, 15, 26, 54, 0, DateTimeKind.Unspecified), "bb5eeab1-9dda-43e5-8fbf-f932cd4bbb1e", "35.193.17.115", "Accounting", 6732, "Wyatt57@yahoo.com", new DateTime(2027, 10, 21, 17, 23, 40, 0, DateTimeKind.Unspecified), 4, "Michelle", "Male", "fdd320ba-58df-4020-97c4-bf4bd6e124c3", new DateTime(2006, 10, 21, 17, 23, 40, 0, DateTimeKind.Unspecified), "Batz", "05653348432", "http://tabitha.org/overriding/generic-fresh-pants/groupware", 2, "Active", "47201263806", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Scotland", (byte)46, new DateTime(1978, 7, 26, 5, 21, 6, 0, DateTimeKind.Unspecified), 6, 1, new DateTime(2015, 12, 10, 20, 30, 8, 0, DateTimeKind.Unspecified), "77b26cea-71cc-460b-a211-5a0356fd870c", "101.157.111.167", "Operations", 5229, "Andreane34@yahoo.com", new DateTime(2028, 12, 2, 12, 35, 17, 0, DateTimeKind.Unspecified), 3, "Jerry", "f76ed70a-38bd-4de9-bfc6-6352daec753b", new DateTime(2010, 12, 2, 12, 35, 17, 0, DateTimeKind.Unspecified), "Doyle", "05799378485", "http://hollie.name/e-commerce", 4, "Active", "72855200084", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "England", (byte)52, new DateTime(1972, 9, 4, 22, 15, 17, 0, DateTimeKind.Unspecified), 6, 4, new DateTime(2002, 5, 18, 16, 43, 53, 0, DateTimeKind.Unspecified), "033ce929-b7e5-4e4c-ab86-82ffc1ddc09e", "235.233.46.160", "Administrative", 6021, "Josue.OConner70@gmail.com", new DateTime(2026, 10, 1, 1, 54, 36, 0, DateTimeKind.Unspecified), 4, "Lyric", "Male", "bee4d900-0dbe-4765-87a4-3f6a43e24545", new DateTime(2008, 10, 1, 1, 54, 36, 0, DateTimeKind.Unspecified), "Graham", "05408926565", "http://virgil.net/redundant", 3, "Passive", "11985907878", null, null, null },
                    { 4, "England", (byte)47, new DateTime(1977, 5, 1, 13, 28, 54, 0, DateTimeKind.Unspecified), 7, 3, new DateTime(2003, 11, 23, 9, 16, 16, 0, DateTimeKind.Unspecified), "33f2d632-c82f-45ca-aff1-19a960e33053", "157.139.113.11", "Marketing", 6913, "Virginie_Predovic57@hotmail.com", new DateTime(2027, 4, 23, 11, 54, 16, 0, DateTimeKind.Unspecified), 4, "Alvera", "Female", "a50e0a5d-3829-4c11-8d8a-daa462139016", new DateTime(2006, 4, 23, 11, 54, 16, 0, DateTimeKind.Unspecified), "DuBuque", "05472517914", "https://giovanny.org/architect", 4, "Passive", "39883810398", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "Gender", "Guid", "HireDate", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "England", (byte)36, new DateTime(1988, 9, 2, 2, 26, 42, 0, DateTimeKind.Unspecified), 4, 1, new DateTime(2015, 6, 25, 15, 58, 52, 0, DateTimeKind.Unspecified), "d29b9c60-0492-40c5-ab46-a0c2e236dac3", "80.237.172.247", "Administrative", 3676, "Idella.Howell86@yahoo.com", new DateTime(2027, 3, 4, 9, 49, 13, 0, DateTimeKind.Unspecified), 3, "Jared", "Male", "bbe7ae0c-d097-45b9-a4db-be359d58b372", new DateTime(2015, 3, 4, 9, 49, 13, 0, DateTimeKind.Unspecified), "Haag", "05363839945", "https://billy.org/bandwidth", 4, "60996438492", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "91824 Jimmie Pines, Pamelastad, American Samoa", (byte)40, new DateTime(1984, 8, 10, 3, 20, 34, 0, DateTimeKind.Unspecified), "Eloise94@gmail.com", "Bernadine", "Kris", "05150830658", "demetrius.info", "91355759993", new DateTime(2019, 7, 11, 13, 9, 32, 0, DateTimeKind.Unspecified) },
                    { 2, "76327 Braun Camp, Justicestad, Iceland", (byte)54, new DateTime(1970, 11, 3, 3, 53, 41, 0, DateTimeKind.Unspecified), "Drew_Anderson@hotmail.com", "Tyshawn", "Schmitt", "05819874888", "aiden.com", "86861163517", new DateTime(2018, 3, 8, 22, 50, 7, 0, DateTimeKind.Unspecified) },
                    { 3, "2905 Boehm Views, Port Jovanmouth, Angola", (byte)47, new DateTime(1978, 3, 2, 21, 12, 7, 0, DateTimeKind.Unspecified), "Damon.Rau@hotmail.com", "Isom", "Vandervort", "05428353195", "emmalee.org", "35346179441", new DateTime(2000, 7, 14, 13, 56, 18, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[] { 4, "9862 Spinka Island, Goyetteport, Cyprus", (byte)44, new DateTime(1980, 9, 9, 2, 30, 36, 0, DateTimeKind.Unspecified), "Tommy_Will@hotmail.com", "Lupe", "Male", "Hansen", "05561825704", "kaley.name", "56108097608", new DateTime(2015, 12, 12, 14, 14, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, "8389 Sabryna Neck, Lessiefort, South Africa", (byte)25, new DateTime(2000, 2, 27, 4, 45, 39, 0, DateTimeKind.Unspecified), "Milton_Langosh89@hotmail.com", "Stella", "Halvorson", "05938408559", "mariane.org", "19877753725", new DateTime(2017, 2, 14, 9, 19, 17, 0, DateTimeKind.Unspecified) },
                    { 6, "8916 Myra Mountains, Marcellaland, Latvia", (byte)21, new DateTime(2003, 10, 18, 21, 26, 44, 0, DateTimeKind.Unspecified), "Hazel.Swaniawski25@hotmail.com", "Dallin", "Hermiston", "05015261212", "florida.info", "13595971332", new DateTime(2021, 8, 11, 13, 18, 47, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[] { 7, "943 Lennie Plain, South Declan, Hungary", (byte)38, new DateTime(1987, 1, 8, 14, 32, 38, 0, DateTimeKind.Unspecified), "Darren.Harber@yahoo.com", "Eryn", "Male", "Keeling", "05557920130", "zena.biz", "43199355154", new DateTime(2021, 5, 20, 4, 41, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[] { 8, "422 Bogisich Haven, New Ocie, Afghanistan", (byte)38, new DateTime(1986, 12, 12, 5, 11, 47, 0, DateTimeKind.Unspecified), "Daryl81@yahoo.com", "Royce", "Oberbrunner", "05833457202", "kasandra.biz", "35709738301", new DateTime(2010, 6, 12, 6, 59, 32, 0, DateTimeKind.Unspecified) });

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
