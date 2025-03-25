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
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CountryDescription = table.Column<string>(type: "nvarchar(190)", maxLength: 190, nullable: true),
                    CountryPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "77b160f8-132c-4860-aabd-d76406dbb203"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 555, DateTimeKind.Local).AddTicks(8724)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8d5211b7-0433-48ec-92c3-43d4efdb1e27"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ee059693-9fb2-4e63-882e-a810614890d3"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 553, DateTimeKind.Local).AddTicks(9088)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "66cdae2c-924f-4946-b3c2-c4a99e2bf459"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c89b4bad-0332-46a0-b413-77a42ed7344e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 563, DateTimeKind.Local).AddTicks(2862)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "59769ff2-e1ac-4fa6-9224-838a7dc70dc2"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "542453ca-2f48-4a3b-9be2-f6ba5783a7e8"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 554, DateTimeKind.Local).AddTicks(6079)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f6098cde-24c8-4118-ba78-2d1135212beb"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b2d29b7d-33d5-4196-af80-43d6252ade77"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 554, DateTimeKind.Local).AddTicks(9921)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4ed7dad2-0815-4500-a4eb-ed9ae47884ac"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "524a4b77-65ab-4e41-a995-4d3e0ef46a2c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 564, DateTimeKind.Local).AddTicks(2284)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a0f37f34-ad18-47f0-abb7-68d11cad98fb"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "14b468cd-e768-4e13-89b1-081e5a48feb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 564, DateTimeKind.Local).AddTicks(5355)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fb597568-f565-4a4b-8f2c-94ba4c0bdc87"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "92f1325e-c557-4af0-9b60-01515a3aa762"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 555, DateTimeKind.Local).AddTicks(3784)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "05a40ddf-ccf6-45ae-be92-b5e01e9c8355"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 568, DateTimeKind.Local).AddTicks(5043)),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "163e79b5-084d-4a52-979b-af289d16ec5a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 554, DateTimeKind.Local).AddTicks(3319)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "991afde5-03bd-4bf8-b29c-5edc390f0f98"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5c3fe1b2-e4e9-43c0-bf2d-87ff5f97dd90"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 563, DateTimeKind.Local).AddTicks(8878)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0eface94-61c6-45e5-a30a-d97ee422703d"),
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
                    DaysWorked = table.Column<int>(type: "int", nullable: false),
                    CurrentPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    ResidenceRegionId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9e965561-e256-4b0d-8329-2e3143f55013"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 557, DateTimeKind.Local).AddTicks(4550)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "16dbd3aa-7309-4aad-8c87-4a69881c8935"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "878e68fc-b30c-428d-8a32-4c0f12597cc8"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 545, DateTimeKind.Local).AddTicks(8926)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fa7cd605-f9c2-457c-97c5-3791e146b20b"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8ff5ffe4-17d8-4957-a869-3a4136ca8e2a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 553, DateTimeKind.Local).AddTicks(1561)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ac95461a-7f1f-4bc6-b2e7-cf276d2abb84"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "81bcf5c7-e6d8-4dc9-8aff-5c7e7a8a8fa3"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 556, DateTimeKind.Local).AddTicks(2518)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4abe2a14-91d9-49fd-b863-87d6f1bd3726"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b6cab846-78d7-4bd6-805e-6121d64293e9"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 556, DateTimeKind.Local).AddTicks(9097)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f4eee1f4-d628-4c59-90ba-36f4b89981aa"),
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
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 569, DateTimeKind.Local).AddTicks(752))
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "faacd8ab-d416-4747-9a51-b8b5ad00fe09"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 562, DateTimeKind.Local).AddTicks(764)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "aa93c43a-4a7c-4d45-bc53-80b94fc3a775"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "09d0bd24-ba09-40a9-a5e3-0af7ff8e07ea"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 562, DateTimeKind.Local).AddTicks(6371)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "51ec9a4e-47ce-4564-9c93-33236b8a0b20"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6f2afed9-25ce-455a-9f5e-71cfaf98d85d"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 560, DateTimeKind.Local).AddTicks(7566)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9a4564c4-3dbf-4ee6-b142-0798cc0ef91c"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "615900c1-d20b-4677-8df5-ee90199791c1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 561, DateTimeKind.Local).AddTicks(1866)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7f5ffe7d-4b51-4565-8cf7-a836fd132267"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0c313d3e-9335-4f69-97a1-307f11a61d3c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 561, DateTimeKind.Local).AddTicks(6425)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "aba21a6d-44fb-4a89-a40d-e3de88946973"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ef012513-6ed2-4fdb-8c0c-eee6a3467792"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 564, DateTimeKind.Local).AddTicks(9248)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8df58745-8928-4985-ac5d-3c868265b5fd"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5db011af-f978-46ed-80d1-0af2ecb06d7a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 565, DateTimeKind.Local).AddTicks(6466)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "53867f95-89b9-4eeb-a668-203e53936548"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "72f680de-df20-49c3-8b9c-8eb61c5a858b"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 565, DateTimeKind.Local).AddTicks(2792)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b1d17e8c-aed8-4dd2-9004-2c568bbd7093"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "55c453ed-2505-4c11-9bfc-b21619973172"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 566, DateTimeKind.Local).AddTicks(1983)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d0cfc83e-dbc7-4737-9af4-a5e004841bda"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fb5e64b8-b248-4f81-a7c6-eb6c0a665c14"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 559, DateTimeKind.Local).AddTicks(8519)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "90071caa-a0d3-42de-a028-5b1f5ad67cae"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7d7f96a5-4040-46ea-84b8-e44f7ddf0cf4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 559, DateTimeKind.Local).AddTicks(3488)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9a135857-cfb7-4fd8-83ce-654ffaacd6cd"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "15140d8e-0e37-43a0-a833-31d2a72e7f2c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 25, 3, 46, 59, 560, DateTimeKind.Local).AddTicks(3019)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3ee79cb4-06a5-4f5a-8a0c-b8e6bba33d24"),
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 1, 0, "014e084d-3a61-479f-b219-9dc3ceb7064a", null, new DateTime(2014, 4, 4, 12, 50, 21, 0, DateTimeKind.Unspecified), "510d9d12-a558-4ede-b4c2-e1f27b82fd70", "CreatedIPAdress 0", "Email 0", false, "ee7c8970-37e6-40ff-a2a3-6e2ac109eb75", false, null, "EMAİL 0", "USERNAME 0", "$2a$11$/a9BJtyqekKH5CxtfkedAuHTnRWIC5GVh.Ht/qc3PzEexGG3CRpxW", "PNumber 0", false, "258ba2db-4205-4500-9597-a3fb6db83cfe", false, null, null, null, "UserName 0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 2, 0, "23035c05-d4f7-4d62-93b3-d55efc6da981", null, new DateTime(2002, 4, 13, 22, 38, 3, 0, DateTimeKind.Unspecified), "5cf80f86-f504-4579-bcf2-36d0549086a1", "CreatedIPAdress 1", "Email 1", false, "49ecff87-6bf3-4d78-8ebd-c4755fb7c0c5", false, null, "EMAİL 1", "USERNAME 1", "$2a$11$/O7QMv5ZX6GomhhTxaGSfOH1IQ7kgyphUG0ltePufisGGEHxfkjDG", "PNumber 1", false, "8fad04d7-6317-4026-9ca0-029b629bf135", "Active", false, null, null, null, "UserName 1" },
                    { 3, 0, "e0bb9ede-1efb-45a4-8d3e-44a2ed1e052a", null, new DateTime(2012, 9, 4, 4, 59, 44, 0, DateTimeKind.Unspecified), "e21d8e55-792f-4a8f-8145-408549206702", "CreatedIPAdress 2", "Email 2", false, "155e95a9-6909-4f19-8561-0a83cacc34dc", false, null, "EMAİL 2", "USERNAME 2", "$2a$11$cidf7z5.RHp3jCbEEX/kQukLCo7.SuSv3t4xSJ2HrEygZH5c6jm2.", "PNumber 2", false, "ae44b540-2603-48c8-b38b-4b1fbad5bbdd", "Passive", false, null, null, null, "UserName 2" },
                    { 4, 0, "50be9fe2-0a01-4775-b3c7-11bd08caf029", null, new DateTime(2019, 7, 1, 16, 34, 46, 0, DateTimeKind.Unspecified), "94724bd5-89c5-46ae-827e-01645ceba40b", "CreatedIPAdress 3", "Email 3", false, "78cb11f0-c5c9-465e-8330-8d281afc39b8", false, null, "EMAİL 3", "USERNAME 3", "$2a$11$BXc91ZHTD95/UNpiKVkTJuIveOfa3LGS1mpi2v73cx1UsKuCJKPgi", "PNumber 3", false, "bc71b51a-9537-43c5-84bf-2ff84ba1d667", "Active", false, null, null, null, "UserName 3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 5, 0, "8b121395-dfff-4d4c-a105-37000678cebd", null, new DateTime(2000, 7, 26, 6, 26, 27, 0, DateTimeKind.Unspecified), "f197fc33-564a-463d-be04-016b05df5212", "CreatedIPAdress 4", "Email 4", false, "35091155-9576-47c3-9549-991ade1bf622", false, null, "EMAİL 4", "USERNAME 4", "$2a$11$hsEIuSoYktF0Lg85qXhyOuf9xHtVpPMEURDXAEzK96MV7Km9SJv/u", "PNumber 4", false, "17750dab-02f9-43fc-9c14-ee66bf96db64", false, null, null, null, "UserName 4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 6, 0, "07f693cd-0f4b-4800-a12f-a23161ab8cef", null, new DateTime(2018, 6, 27, 4, 9, 15, 0, DateTimeKind.Unspecified), "c2b50fc1-7311-4b3e-8695-4edd8e37a143", "CreatedIPAdress 5", "Email 5", false, "db4f1813-8d13-4ee5-8bb9-96c93272859d", false, null, "EMAİL 5", "USERNAME 5", "$2a$11$fwky/Dmo6sCsnGRQqMzW8O9CBCZfrhVQvotPjgs4.IBZK9KrW3V3q", "PNumber 5", false, "35ddb6f1-2ac2-400e-8115-48d918418c96", "Active", false, null, null, null, "UserName 5" },
                    { 7, 0, "681afd18-fc6f-4b27-80b3-9a0e227cb70e", null, new DateTime(2018, 6, 3, 17, 45, 38, 0, DateTimeKind.Unspecified), "eb3533eb-87d5-44d1-a8c4-d3b788637885", "CreatedIPAdress 6", "Email 6", false, "b07ec015-e9c0-4d8c-9320-ef9fcc85fa99", false, null, "EMAİL 6", "USERNAME 6", "$2a$11$UYxdxyWIiewFVAICG7qrhuxczmfIdb6Jv587aedTiy4BlsAnM2jaK", "PNumber 6", false, "9cc29b21-c1ba-401f-8868-ddb3fba8407f", "Active", false, null, null, null, "UserName 6" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 8, 0, "70660687-46f3-40c6-99fc-485fa95c3e0b", null, new DateTime(2012, 10, 20, 6, 41, 17, 0, DateTimeKind.Unspecified), "bc63c3fd-cabb-460f-a9e0-3b7d0a47652c", "CreatedIPAdress 7", "Email 7", false, "0e96755b-5500-4302-a77a-462c421296da", false, null, "EMAİL 7", "USERNAME 7", "$2a$11$2kJ14NeyGwWwn7mwojH7wO/farOoRmkkBugDAcEwxw0lUSciUtEJO", "PNumber 7", false, "eeef4721-dcce-4120-b195-1401a09bb974", false, null, null, null, "UserName 7" },
                    { 9, 0, "e80f39f7-2c74-4dd5-8192-be8fe635459d", null, new DateTime(2004, 12, 9, 10, 23, 50, 0, DateTimeKind.Unspecified), "609e1f6f-0706-40ef-a339-ac651e21d49a", "CreatedIPAdress 8", "Email 8", false, "e668db5e-1438-459b-85c3-f0ae1146aaef", false, null, "EMAİL 8", "USERNAME 8", "$2a$11$2MGZAVyCqpZpn9xlSrqpuekekOGzsXpufRjrc9Rr1OCe7JjiNK.NS", "PNumber 8", false, "31268fd0-578d-49d2-a122-869b1f99393b", false, null, null, null, "UserName 8" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 10, 0, "042fab42-c5de-4a6e-8720-d4f9d39542f6", null, new DateTime(2004, 4, 19, 10, 34, 45, 0, DateTimeKind.Unspecified), "bee24db9-dc81-4af7-b29f-db27f922d393", "CreatedIPAdress 9", "Email 9", false, "fa927344-e5d1-45dc-b5fe-4740ea5bb852", false, null, "EMAİL 9", "USERNAME 9", "$2a$11$HC2yQqBj2D1sn6If3zRJPut2F8gPFojphsR9b8FAr2tE.7pmNGia.", "PNumber 9", false, "96d59572-f737-4823-976a-4022c595aea8", "Active", false, null, null, null, "UserName 9" });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Adress 0", (byte)68, new DateTime(1956, 5, 16, 11, 17, 8, 0, DateTimeKind.Unspecified), "Email 0", "FirstName 0", "Male", "LastName 0", "PNumber 0", "PhotoPath 0", "TCN 0", new DateTime(2010, 4, 14, 22, 42, 36, 0, DateTimeKind.Unspecified) },
                    { 2, "Adress 1", (byte)38, new DateTime(1986, 4, 16, 23, 16, 41, 0, DateTimeKind.Unspecified), "Email 1", "FirstName 1", "Male", "LastName 1", "PNumber 1", "PhotoPath 1", "TCN 1", new DateTime(2016, 2, 16, 17, 17, 23, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[] { 3, "Adress 2", (byte)37, new DateTime(1988, 2, 13, 20, 19, 44, 0, DateTimeKind.Unspecified), "Email 2", "FirstName 2", "LastName 2", "PNumber 2", "PhotoPath 2", "TCN 2", new DateTime(2017, 7, 9, 16, 43, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, "Adress 3", (byte)21, new DateTime(2003, 4, 14, 12, 45, 24, 0, DateTimeKind.Unspecified), "Email 3", "FirstName 3", "Female", "LastName 3", "PNumber 3", "PhotoPath 3", "TCN 3", new DateTime(2010, 9, 8, 22, 51, 23, 0, DateTimeKind.Unspecified) },
                    { 5, "Adress 4", (byte)27, new DateTime(1997, 7, 3, 6, 36, 19, 0, DateTimeKind.Unspecified), "Email 4", "FirstName 4", "Male", "LastName 4", "PNumber 4", "PhotoPath 4", "TCN 4", new DateTime(2004, 12, 7, 17, 59, 38, 0, DateTimeKind.Unspecified) },
                    { 6, "Adress 5", (byte)23, new DateTime(2001, 8, 22, 23, 10, 26, 0, DateTimeKind.Unspecified), "Email 5", "FirstName 5", "Male", "LastName 5", "PNumber 5", "PhotoPath 5", "TCN 5", new DateTime(2007, 2, 4, 4, 35, 25, 0, DateTimeKind.Unspecified) },
                    { 7, "Adress 6", (byte)36, new DateTime(1989, 1, 7, 4, 14, 48, 0, DateTimeKind.Unspecified), "Email 6", "FirstName 6", "Male", "LastName 6", "PNumber 6", "PhotoPath 6", "TCN 6", new DateTime(2018, 11, 23, 15, 49, 52, 0, DateTimeKind.Unspecified) },
                    { 8, "Adress 7", (byte)59, new DateTime(1965, 12, 22, 23, 46, 31, 0, DateTimeKind.Unspecified), "Email 7", "FirstName 7", "Male", "LastName 7", "PNumber 7", "PhotoPath 7", "TCN 7", new DateTime(2016, 3, 27, 1, 21, 31, 0, DateTimeKind.Unspecified) }
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
