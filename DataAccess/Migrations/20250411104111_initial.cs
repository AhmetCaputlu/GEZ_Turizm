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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4c5d1da0-9d92-4352-bbe1-384fd3afcbd1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 986, DateTimeKind.Local).AddTicks(2751)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1deaa56f-a8da-4473-ab2a-0d36e8f0807e"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7de86bf5-61a5-4021-a55f-7908373a2a07"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 979, DateTimeKind.Local).AddTicks(718)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "dcd3efc4-f9b6-46f0-ab58-b61b995faae0"),
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
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CategoryType = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValue: "Unknown"),
                    Description = table.Column<string>(type: "nvarchar(130)", maxLength: 130, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f1bcdee0-2e30-47b0-83f4-31df42b54b79"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 8, DateTimeKind.Local).AddTicks(7741)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e20b5bc0-fb81-4d4f-b00c-36bdf0c11e8b"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b2bf3707-7cda-4522-82ec-f406f102f15e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 981, DateTimeKind.Local).AddTicks(5969)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c79312ef-066d-46c5-bb64-9d6c44574bfc"),
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
                    table.PrimaryKey("PK_ProductSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalVehicleSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "da86db57-f909-4d35-bba2-7214fb378a61"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 983, DateTimeKind.Local).AddTicks(5440)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f8723e76-97dd-46a7-a7d1-113200f3fca2"),
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
                name: "ResidenceRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b0405f8c-d668-43c4-910d-f6c9bd46050e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 11, DateTimeKind.Local).AddTicks(4998)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d7e73fa2-092b-426b-b65a-2ceb1c4eaac6"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    TouristPopulation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasHotelFacility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8d8a97f1-4ddb-4ea2-bdaa-b04f57611107"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 12, DateTimeKind.Local).AddTicks(6996)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "487b4637-26ae-41d3-b259-be39e539ded4"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9ec93433-869c-4b78-9941-3cdb27311d36"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 984, DateTimeKind.Local).AddTicks(9082)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "acfda68d-ede6-4e9b-a867-145c7fbcd751"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 22, DateTimeKind.Local).AddTicks(4557)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "IP verilmedi"),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PartnerCompanyId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "86adc428-1b67-4ac9-9bb3-33163656214f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 980, DateTimeKind.Local).AddTicks(4780)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d72854ee-4b76-44aa-92c9-8c2ae5326399"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8f842567-142c-4e07-b3dc-8de57ebfe6cc"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 10, DateTimeKind.Local).AddTicks(2307)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "adc83816-018e-4e33-a6e1-41ec48f688b3"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "546f382e-1163-4493-b805-9a47ff44ad46"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 991, DateTimeKind.Local).AddTicks(1157)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9184cb67-6c81-41db-b77e-06a80f0e41df"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8d5f3295-8484-4506-a584-cbdeddb5e715"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 975, DateTimeKind.Local).AddTicks(8200)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "842b332d-216c-4a7d-aec5-e94785954efe"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7e30047f-fe3f-4846-91b7-192c9dcfa0ea"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 977, DateTimeKind.Local).AddTicks(5177)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f786cd13-7bff-4a53-9b4f-98b33937a6c6"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "08e4c0ce-bd21-4e3e-abf5-f8086669e5ba"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 987, DateTimeKind.Local).AddTicks(9310)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "61890edf-eeb0-4eb4-a5b0-d3f1fa5c7b10"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "55afa8ca-96a6-4060-a150-425ac7e41b42"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 989, DateTimeKind.Local).AddTicks(5420)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ed3968c9-acaa-4148-9480-d80a487bbbc2"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 637, DateTimeKind.Local).AddTicks(4779)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "IP verilmedi"),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Unknown"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false, defaultValue: "Unknown"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TCN_Passport = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8aa11dec-f687-4aa7-9143-86a3aae16aae"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 6, DateTimeKind.Local).AddTicks(2038)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b57eacce-71c6-4cb4-bc53-7b1dc7ce9c61"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CommissionRate = table.Column<byte>(type: "tinyint", nullable: false),
                    TotalCostwithCommission = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9e1d76cc-c948-4ece-bbbc-ad02d7aac422"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 7, DateTimeKind.Local).AddTicks(4275)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4f9ad1f5-4519-40d6-b070-450a44f70cb8"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CommissionRate = table.Column<byte>(type: "tinyint", nullable: false),
                    TotalCostwithCommission = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f91aff1d-24c5-4832-b4a3-c377b48d5aff"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 2, DateTimeKind.Local).AddTicks(631)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6b5c8965-802d-49f8-a506-9b7a78507aed"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    Note = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ff7d49d3-229c-403d-83a5-4d3d311479a5"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 3, DateTimeKind.Local).AddTicks(5804)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ade5c824-45af-42f1-8f26-cc4395f90f16"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    Note = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e46697ad-6451-4535-b01f-f6a20f676b32"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 4, DateTimeKind.Local).AddTicks(9214)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "190c1380-232c-4be0-8aa7-0655d422050a"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    Note = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "604e0214-599a-4238-8117-2f227d448828"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 13, DateTimeKind.Local).AddTicks(8981)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "820aa597-08f3-43a0-9646-1a7a02fbad2e"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    TicketName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DepartureAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DestinationAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: true),
                    NetCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b83d276b-6db0-4efd-a661-10436cbcda4d"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 17, DateTimeKind.Local).AddTicks(5255)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8e8fd032-fefe-48d1-b8bd-be994aabf861"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e49c3f14-3ccd-4735-a503-eee2f4d0d1fb"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 16, DateTimeKind.Local).AddTicks(2403)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e42751fc-7d12-4775-8137-b76dc767e825"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    TicketName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DepartureAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DestinationAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: true),
                    NetCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7df311e2-f922-4da0-bc63-30e69b1885ee"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 19, DateTimeKind.Local).AddTicks(734)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2fa62cab-0261-40e1-b046-e29c9593d9a5"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fbd866dd-183c-4154-aa54-082f473e3529"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 999, DateTimeKind.Local).AddTicks(5600)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e670d4de-ba73-4a22-9b9e-e233e9135175"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    UnitPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b0827d30-99fd-4692-8dcc-e9e9e04506be"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 10, 998, DateTimeKind.Local).AddTicks(2565)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "40275a72-c161-4a55-a59f-a68b844b97fa"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    UnitPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
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
                    ContractDriverId = table.Column<int>(type: "int", nullable: false),
                    RentalVehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDrivers_RentalVehicles", x => new { x.ContractDriverId, x.RentalVehicleId });
                    table.ForeignKey(
                        name: "FK_ContractDrivers_RentalVehicles_ContractDrivers_ContractDriverId",
                        column: x => x.ContractDriverId,
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9edd89ed-1130-4483-a025-0e1f514769a6"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 13, 41, 11, 0, DateTimeKind.Local).AddTicks(8321)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3ab2f3ec-66c0-4dd0-93c4-1a268d17aede"),
                    CreatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: ""),
                    IsUpdated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    UpdatedIPAddress = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Unknown"),
                    UnitPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "NorthAmerica", "TR", "Eveniet est sit cupiditate sint distinctio.", "Turkey", "+90", new DateTime(2018, 7, 13, 14, 42, 33, 0, DateTimeKind.Unspecified), "961af1f2-1481-45e9-975d-12b8a80a9026", "237.128.183.152", "568d0b29-dc70-412e-85ae-8f426f6c16d5", "No", "Active", null, null, null },
                    { 2, "Asia", "RU", "Nulla quo minus consequatur laboriosam perspiciatis.", "Russia", "+7", new DateTime(2017, 8, 12, 20, 56, 47, 0, DateTimeKind.Unspecified), "c648f32f-c3ed-4a5d-bbe7-44d14f24cd05", "28.51.58.28", "b6e26034-29a9-4235-89a0-da56872f60e7", "No", "Passive", null, null, null },
                    { 3, "None", "USA", "Distinctio et quod nam doloremque non.", "United States of America", "+1", new DateTime(2009, 8, 16, 13, 31, 33, 0, DateTimeKind.Unspecified), "3de9a2cb-4d36-4d9d-9bdf-92f244ff6142", "189.158.152.9", "f086e13f-43ed-4132-a03a-57d226c19881", "Yes", "Passive", null, null, null },
                    { 4, "Africa", "SA", "İpsam laboriosam optio provident saepe voluptatem.", "Kingdom of Saudi Arabia", "+966", new DateTime(2013, 1, 23, 21, 49, 38, 0, DateTimeKind.Unspecified), "4c53b366-aaa8-4b64-8054-9f130a0ec625", "83.25.134.205", "078abc91-24f2-4472-b1a5-0553355cf8a5", "No", "Active", null, null, null },
                    { 5, "Europe", "GER", "Dolores est est vel sapiente ut.", "Germany", "+49", new DateTime(2012, 4, 18, 23, 52, 39, 0, DateTimeKind.Unspecified), "23ff024c-ef13-40d5-9696-ae97f7f37ad8", "69.82.7.19", "9fbe865c-3dfc-4259-947d-f2436953587d", "No", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "Yes", "91175 Bergnaum Mission, Millsside, Bahrain", 11012.584116350970000m, "Feest, O'Connell and Gutmann Inc", "Ryann Wisozk", "Dynamic Implementation Consultant", new DateTime(2009, 1, 15, 6, 52, 53, 0, DateTimeKind.Unspecified), "6dc84309-bafa-4f41-89c4-d78ace2a1a2a", "182.83.105.86", 88542.095136674950000m, 99554.679253025920000m, "Jairo.Skiles98@gmail.com", "7ff21e54-8b34-4177-a4fb-bbeebd4c6ad9", "No", "02122708346", "Active", null, null, null },
                    { 2, "Yes", "204 Collins Lodge, Maverickside, Ukraine", -25090.694021345850000m, "Schuster, Quitzon and Schneider and Sons", "Augustus Monahan", "Dynamic Identity Architect", new DateTime(2006, 8, 3, 20, 19, 10, 0, DateTimeKind.Unspecified), "a76cf05d-6502-407e-9f44-73df7cde7f8f", "15.51.34.12", 98462.944902548440000m, 73372.250881202590000m, "Howard_Langworth35@hotmail.com", "cdc45bc9-707d-4679-b5eb-aae1a2582e9d", "Yes", "02110486294", "Active", null, null, null },
                    { 3, "Yes", "47618 Ally Course, North Bradlyside, Netherlands", 31324.770407317590000m, "Rodriguez, Mosciski and Swaniawski Group", "Laisha Collier", "Dynamic Interactions Strategist", new DateTime(2019, 2, 16, 17, 48, 25, 0, DateTimeKind.Unspecified), "d76e6397-710b-4967-b16b-d42162b7ba14", "235.81.15.0", 19215.253203688630000m, 50540.023611006220000m, "Vaughn_Kuvalis@hotmail.com", "8fedc167-dfc8-48a0-8072-ba30e3fde7f6", "No", "02127525823", "Active", null, null, null },
                    { 4, "No", "189 Harber Track, Port Amayabury, Monaco", 54443.533150161360000m, "Kassulke, Grimes and Collier Inc", "Trystan Mitchell", "District Factors Representative", new DateTime(2012, 5, 22, 16, 50, 27, 0, DateTimeKind.Unspecified), "4b724e3d-0bbb-4afa-9e4f-b1e47663afbd", "151.163.118.142", 32178.726615085390000m, 86622.259765246750000m, "Vena.Kris22@yahoo.com", "e5dda6a9-85a2-4689-b4e1-51dcefcae56a", "No", "02135200031", "Passive", null, null, null },
                    { 5, "Yes", "1009 Chaya Forges, West Jarrellland, Marshall Islands", 42103.996944787800000m, "Hane, Lang and Bergnaum and Sons", "Stevie Larson", "International Configuration Officer", new DateTime(2012, 9, 15, 20, 55, 21, 0, DateTimeKind.Unspecified), "10598204-b2e8-4ec0-8484-b579d3fb46f7", "56.191.103.249", 28074.783462228820000m, 70178.780407016620000m, "Cletus.Kertzmann91@yahoo.com", "e27cdd4f-4764-41a9-83b8-0e917ad60395", "Yes", "02160725966", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CategoryType", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "omnis", "Camping_Hiking", new DateTime(2001, 1, 11, 7, 53, 41, 0, DateTimeKind.Unspecified), "398683e5-e266-4d10-8485-be18e6067ac1", "171.47.157.92", "provident minus ipsam ducimus", "04c7b4ba-580d-443a-b0bd-4a8f06bcae04", "No", "Passive", null, null, null },
                    { 2, "assumenda", "Souvenir", new DateTime(2001, 9, 6, 12, 44, 31, 0, DateTimeKind.Unspecified), "2748c0c7-9a35-4232-afaa-c73faecc3b4b", "93.226.175.168", "quis vero est nihil", "52306366-5e0d-4333-a876-15efe2ab466f", "No", "Active", null, null, null },
                    { 3, "at", "Camping_Hiking", new DateTime(2006, 9, 10, 7, 15, 53, 0, DateTimeKind.Unspecified), "347244b5-5488-41fc-94d7-afcaac28a662", "233.123.94.119", "ducimus reprehenderit facere et", "5162d613-720c-4b63-8ed6-ab0482ea9bc7", "No", "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CategoryType", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "Guid", "IsUpdated", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "numquam", "Refreshment", new DateTime(2013, 11, 2, 4, 30, 53, 0, DateTimeKind.Unspecified), "3b453100-7ce8-4678-8cdc-976e8aa93ddc", "8.69.230.70", "repudiandae temporibus at iure", "7496b96f-41f3-4ac9-846a-42cd758825f3", "No", null, null, null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName", "CategoryType", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "itaque", "Camping_Hiking", new DateTime(2017, 10, 26, 13, 46, 30, 0, DateTimeKind.Unspecified), "ea3c1dcd-36e4-45fb-a3e2-6cf6f7975361", "176.198.151.253", "voluptatem mollitia eos ipsa", "dcbc814a-f1c8-44ce-acc7-9fd72c0442cd", "No", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "ProductSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "229 McClure Point, Port Caterinastad, Burkina Faso", "Runolfsdottir - Walter Group", "Arthur Windler", "Direct Interactions Assistant", new DateTime(2019, 12, 12, 13, 54, 8, 0, DateTimeKind.Unspecified), "47e6595f-4e55-4d4e-9007-48eeab7139da", "253.107.114.53", "Sammie.Marquardt@gmail.com", "97142efb-1534-4fd5-9f2d-71f6e3492ed3", "No", "02122654954", null, null, null });

            migrationBuilder.InsertData(
                table: "ProductSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "4227 Emely View, Kassandrahaven, French Polynesia", "Corwin and Sons and Sons", "Julia Wiza", "Investor Security Administrator", new DateTime(2004, 2, 16, 9, 44, 28, 0, DateTimeKind.Unspecified), "02279629-1af0-46cf-a4ce-bcba1cae10ba", "91.184.91.58", "Kayley87@hotmail.com", "1ffcd9c0-ba2e-4a6c-94c3-eb26ee707179", "No", "02154776961", "Passive", null, null, null },
                    { 3, "8499 Efrain Fork, Bernhardbury, Botswana", "Shields Inc and Sons", "Tianna Schuppe", "Senior Program Designer", new DateTime(2018, 2, 16, 20, 11, 47, 0, DateTimeKind.Unspecified), "84c32b0c-f7c4-4fb3-9199-3dbdd5a82bbb", "106.14.38.0", "Zetta_Altenwerth61@yahoo.com", "ffaa23a0-8341-459d-a5a8-99b0d0c51b81", "No", "02123562938", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "54457 Cummings Centers, Prosaccoberg, Peru", "Braun, Herman and Bosco Inc", "Zion Prosacco", "Lead Data Analyst", new DateTime(2004, 7, 2, 2, 59, 13, 0, DateTimeKind.Unspecified), "f65f29fa-6368-48a9-93c7-52272a4a177d", "184.90.98.164", "Reagan.Mayer15@yahoo.com", "456d24ee-97e8-4fd9-ab6e-6607c474b077", "Yes", "02162653061", null, null, null });

            migrationBuilder.InsertData(
                table: "ProductSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "180 Carter Key, Kirlinview, Costa Rica", "Reichert, Kunze and Abernathy and Sons", "Kira Zboncak", "Regional Web Administrator", new DateTime(2021, 2, 25, 23, 19, 38, 0, DateTimeKind.Unspecified), "800dcf49-a0e8-4b89-b7d3-17bd91ee87e9", "61.187.70.164", "Chance_Christiansen@gmail.com", "dbe2dd87-e9ff-4125-b225-3560e1211ec7", "No", "02143786858", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "654 Cordia Parks, Hubertmouth, Bolivia", "Kutch, Boehm and Dickinson Group", "Stacey Schmitt", "Customer Directives Technician", new DateTime(2000, 8, 20, 5, 18, 7, 0, DateTimeKind.Unspecified), "80e77529-3849-4ea7-88ed-dcf58313bebf", "180.131.219.134", "Rosalia.Quitzon33@gmail.com", "6da52987-0489-46cf-a385-58eaee631ed8", "No", "02132257585", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "05608 Rippin Forges, Port Arlene, Pitcairn Islands", "Ankunding, Bauch and Conn Inc", "Amos Nikolaus", "Product Operations Agent", new DateTime(2004, 1, 19, 2, 26, 51, 0, DateTimeKind.Unspecified), "88f88cd9-5c77-4a18-a0dd-ebc04e0f97d4", "170.202.188.187", "Dereck.Pacocha16@gmail.com", "f8b58715-f8ee-421f-9894-8bdcf7a3a221", "No", "02190767785", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "2366 Sage Brooks, Abbigailtown, Antarctica (the territory South of 60 deg S)", "Stanton Inc Group", "Jaleel Lind", "Product Assurance Strategist", new DateTime(2001, 7, 9, 22, 42, 18, 0, DateTimeKind.Unspecified), "5ec028ea-7ee7-4749-8168-930f0dc1580c", "146.81.88.174", "Frederick.Mayert57@hotmail.com", "691a15d0-ac29-4e21-9dd5-bb29b17429ea", "No", "02101626600", "Passive", null, null, null },
                    { 4, "34454 Stanton Shoal, Elwynchester, Honduras", "Osinski - Anderson LLC", "Britney Feeney", "Regional Metrics Analyst", new DateTime(2000, 4, 7, 5, 34, 42, 0, DateTimeKind.Unspecified), "c18c7772-b92f-40e4-97cb-7fbb2693a336", "55.58.251.131", "Maureen_Yost@hotmail.com", "913c5293-6088-4abd-a4f7-dd1eaafa79f5", "No", "02104205658", "Passive", null, null, null },
                    { 5, "7354 Jamar Lake, Port Cristianhaven, Russian Federation", "Klein - Boyer and Sons", "Cameron Sporer", "Principal Web Associate", new DateTime(2015, 4, 3, 1, 54, 53, 0, DateTimeKind.Unspecified), "c7c38d2d-82d5-4ba8-8901-4367bd6f8f00", "240.214.77.163", "Claire77@yahoo.com", "334842d5-d8ee-44e9-9410-ac5db500e1f0", "No", "02133262436", "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ResidenceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "IsUpdated", "Status", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 2, 54, 0, 0), new DateTime(2002, 4, 15, 3, 45, 30, 0, DateTimeKind.Unspecified), "42b7e510-2c33-40e0-8d9e-885637279a07", "135.224.190.65", "ut", "1649664c-063d-4d7c-8857-3d8059528e3f", "No", "Active", "Minibus", null, null, null },
                    { 2, new TimeSpan(0, 1, 56, 0, 0), new DateTime(2013, 10, 7, 13, 28, 53, 0, DateTimeKind.Unspecified), "c65daa94-625d-4377-a6c2-069e007f4ea5", "186.169.57.97", "et", "6e3e558a-433a-489e-90e4-ae540941f9ee", "Yes", "Active", "Minibus", null, null, null },
                    { 3, new TimeSpan(0, 2, 54, 0, 0), new DateTime(2008, 6, 18, 1, 27, 30, 0, DateTimeKind.Unspecified), "9a57a7a3-79b3-40e2-8209-f348777a0d65", "207.252.105.207", "accusantium", "0d129f54-447b-467e-93c4-a0d5525f73df", "No", "Passive", "Bus", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ResidenceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "IsUpdated", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, new TimeSpan(0, 2, 6, 0, 0), new DateTime(2007, 4, 16, 6, 49, 29, 0, DateTimeKind.Unspecified), "14edc0cb-5c4a-4807-9b1c-6804bbcedc98", "30.111.175.164", "rem", "8dacb2f2-61f2-4536-8ee5-037644619b75", "Yes", "Yacht", null, null, null });

            migrationBuilder.InsertData(
                table: "ResidenceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "IsUpdated", "Status", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new TimeSpan(0, 1, 19, 0, 0), new DateTime(2020, 2, 5, 1, 15, 37, 0, DateTimeKind.Unspecified), "7f8da685-112e-42b6-ac64-fd707627db0c", "96.26.100.173", "aut", "fef061ef-88b3-4853-a0b6-b96528e884c3", "No", "Active", "Yacht", null, null, null });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 1, 36, 0, 0), new DateTime(2016, 1, 3, 11, 28, 52, 0, DateTimeKind.Unspecified), "759ffdf8-91a3-4ac9-966e-d71654cfc1ef", "103.10.163.44", "explicabo", "8587bff9-2eb2-4955-88a3-8b72f507ca42", "Yes", "Yes", "No", "No", "ATV", null, null, null },
                    { 2, new TimeSpan(0, 1, 30, 0, 0), new DateTime(2003, 12, 18, 9, 33, 5, 0, DateTimeKind.Unspecified), "ac649a8d-2f36-44c8-90d2-2b372355933a", "146.40.14.151", "accusamus", "6fac59ee-921c-4ba8-be58-866bdd353376", "No", "Yes", "No", "No", "Minibus", null, null, null },
                    { 3, new TimeSpan(0, 1, 24, 0, 0), new DateTime(2005, 9, 6, 19, 49, 35, 0, DateTimeKind.Unspecified), "a6518b59-eb5f-416b-8b3c-1d0dc4fe9c44", "156.254.246.47", "consequuntur", "83295ddc-6fdc-4ec3-b53f-c5f6bc83817f", "No", "No", "No", "Yes", "ATV", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "Status", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, new TimeSpan(0, 2, 57, 0, 0), new DateTime(2000, 5, 4, 10, 19, 34, 0, DateTimeKind.Unspecified), "f691b164-bf60-46c1-a98a-b93fdfa6c7db", "175.141.60.186", "perspiciatis", "fa7eaecc-d410-4bc8-862a-860f5b17ab6d", "No", "No", "No", "Passive", "Yes", "Minibus", null, null, null });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new TimeSpan(0, 1, 12, 0, 0), new DateTime(2007, 11, 7, 6, 48, 19, 0, DateTimeKind.Unspecified), "00c9b7d4-2238-475a-9c12-cbfedd858762", "106.143.99.169", "neque", "768b89fe-89bb-4ece-b768-fad6ad6d4929", "Yes", "No", "No", "Yes", "ATV", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "45573 Kemmer Burg, Lake Americomouth, Malawi", "Bailey and Sons Group", "Hellen Marvin", "Forward Program Architect", new DateTime(2021, 1, 7, 12, 14, 30, 0, DateTimeKind.Unspecified), "f42c9b65-8ef0-4eb5-91e6-2603db5847af", "145.68.121.54", "Leta.Windler77@gmail.com", "575de5dc-b4c8-4f4e-9905-4a92fdc1d8f4", "No", "02157339530", null, null, null },
                    { 2, "777 Larkin Run, North Elliot, Portugal", "Murray - Stiedemann Inc", "Maritza Hettinger", "Corporate Identity Architect", new DateTime(2010, 9, 20, 6, 37, 47, 0, DateTimeKind.Unspecified), "c90ba7df-bc22-4b65-8981-b5d901dca9ef", "202.79.35.119", "Emerson29@gmail.com", "a50be7dd-2c8f-4350-b2aa-d1a18d32bdae", "No", "02166703582", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "1053 Hayes Summit, Port Breannechester, Japan", "Williamson - Johns Group", "Una Will", "Chief Research Agent", new DateTime(2005, 7, 11, 20, 55, 31, 0, DateTimeKind.Unspecified), "2800ac76-970f-4be9-bef9-7930a7774f36", "230.153.171.45", "Cecilia.Renner@yahoo.com", "5c01f699-f7ee-4c1f-bd10-53f0c1b194fb", "No", "02142081000", "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "99287 Santino Fork, South Aracely, Iran", "Kovacek - Marks LLC", "Caesar Leffler", "National Optimization Producer", new DateTime(2016, 6, 5, 5, 13, 50, 0, DateTimeKind.Unspecified), "be1305d9-e56d-48d7-af60-2fda83da53b0", "95.108.197.66", "Leanne96@yahoo.com", "18bc5316-df84-4faf-9067-18ed6a82a35a", "No", "02124921788", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "650 Denesik Cape, South Antoniettaport, United States of America", "Rodriguez - Mertz LLC", "Rocky Bernhard", "Human Brand Executive", new DateTime(2016, 8, 16, 15, 55, 36, 0, DateTimeKind.Unspecified), "73770dc4-aeea-409c-846c-16dcf2f7340f", "2.126.78.55", "Dangelo.Konopelski62@yahoo.com", "64073bb9-8f33-400f-a85c-d89733894e93", "No", "02195773139", "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "ba2ca0ce-81cb-44a3-ac25-0012f395333c", 5, new DateTime(2012, 12, 26, 8, 19, 8, 0, DateTimeKind.Unspecified), "0eb26d3e-462c-4845-96bb-0e110159ee8a", "59.142.66.26", "Edyth6@hotmail.com", false, "f6f88b4e-9c3a-4697-8b7b-0d0e34a1f83f", "No", false, new DateTimeOffset(new DateTime(2025, 4, 18, 13, 41, 11, 145, DateTimeKind.Unspecified).AddTicks(9394), new TimeSpan(0, 3, 0, 0, 0)), "EDYTH6@HOTMAİL.COM", "JERROLD", "$2a$11$dQcwgtQCallzx2A5irsquuHB5nsc0Qj9sS3u3xn.iEXKPcxcB7aiy", "05656864681", false, null, "Active", false, null, null, null, "Jerrold" },
                    { 2, 0, "0d8884e2-00f6-4bac-a479-fc78c55d10d5", 2, new DateTime(2003, 12, 2, 10, 15, 43, 0, DateTimeKind.Unspecified), "a1f2e760-05aa-4866-ba30-8d33e34c4675", "188.175.142.187", "Verna9@hotmail.com", false, "c3c94eed-3959-4354-9591-547d4731721c", "No", false, new DateTimeOffset(new DateTime(2025, 4, 18, 13, 41, 11, 268, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 3, 0, 0, 0)), "VERNA9@HOTMAİL.COM", "RYLEİGH", "$2a$11$pSbvjf06S3UDw8n.ybLfduh5dAmx0T4e5W9f6yLK/6Hbn6RM95NFu", "05916590958", false, null, "Active", false, null, null, null, "Ryleigh" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 3, 0, "8f4a0947-baee-4534-acce-b39c39b3810d", 2, new DateTime(2021, 1, 1, 1, 9, 51, 0, DateTimeKind.Unspecified), "a6dadd62-e434-4a7f-a324-f32793b4a7ab", "154.70.210.77", "Brady_Schuster43@hotmail.com", false, "e7986163-0fb9-41c2-a7b9-5cd4a2fba0d5", "No", false, new DateTimeOffset(new DateTime(2025, 4, 18, 13, 41, 11, 392, DateTimeKind.Unspecified).AddTicks(8181), new TimeSpan(0, 3, 0, 0, 0)), "BRADY_SCHUSTER43@HOTMAİL.COM", "KAYLİ", "$2a$11$KLPizHVfp6bbwlVRRNbKreFWxTcj7Vljhavpd1e1ECyVCAk.jcx4e", "05097821944", false, null, false, null, null, null, "Kayli" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "bc4cd8af-4e1b-480a-87f8-25afe3c5abf0", 4, new DateTime(2010, 11, 27, 9, 22, 25, 0, DateTimeKind.Unspecified), "081a15b3-f748-4719-8952-b12cad935b19", "22.181.35.47", "Isobel74@gmail.com", false, "584c705e-6e64-4f5d-b49b-491753acabc1", "No", false, new DateTimeOffset(new DateTime(2025, 4, 18, 13, 41, 11, 514, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, 3, 0, 0, 0)), "ISOBEL74@GMAİL.COM", "NELS", "$2a$11$3gHYqgpUaTmvCP8p292DFuQiGm2akonYXsTXxtiliGBkcBs8uUc7u", "05292370552", false, null, "Active", false, null, null, null, "Nels" },
                    { 5, 0, "0915ce06-1096-46ef-ba7e-8af6fa3e4675", 5, new DateTime(2009, 9, 9, 19, 52, 32, 0, DateTimeKind.Unspecified), "bb8500e0-b12f-4078-bdb0-737dd9193a3e", "55.51.239.152", "Hannah.Hintz@hotmail.com", false, "e22bd6ad-6f9a-48c4-979c-67bb6ab3f487", "No", false, new DateTimeOffset(new DateTime(2025, 4, 18, 13, 41, 11, 636, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 3, 0, 0, 0)), "HANNAH.HİNTZ@HOTMAİL.COM", "FLO", "$2a$11$hmUxn7KKVWJTkeFh/8xKsOUWkaA5dtKvZQUU5t6PDxt0gYaZXFMYC", "05147372049", false, null, "Passive", false, null, null, null, "Flo" }
                });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Northern Ireland", (byte)48, new DateTime(1976, 11, 25, 6, 55, 15, 0, DateTimeKind.Unspecified), new DateTime(2002, 3, 15, 2, 19, 16, 0, DateTimeKind.Unspecified), "349c5a23-3c9d-4a69-bda3-32ea7abd7a52", "90.219.127.251", "ADB", "Destinee91@yahoo.com", new DateTime(2021, 4, 24, 15, 45, 9, 0, DateTimeKind.Unspecified), 2, "Johnathan", "JohnathanFeest", "Male", "3ac5410a-32ec-432f-b0b6-7da8ed7fc30b", new DateTime(2020, 4, 24, 15, 45, 9, 0, DateTimeKind.Unspecified), "No", "Feest", "05200620451", "https://gloria.info/argentina/borders", "Passive", 3, "29892722508", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Scotland", (byte)52, new DateTime(1973, 4, 5, 18, 48, 50, 0, DateTimeKind.Unspecified), new DateTime(2002, 2, 2, 6, 26, 16, 0, DateTimeKind.Unspecified), "b6da812b-e99b-46e4-a022-e66f09a637e5", "162.150.111.216", "Aiden_Hudson43@gmail.com", new DateTime(2008, 11, 21, 9, 18, 3, 0, DateTimeKind.Unspecified), 1, "Angelina", "AngelinaTorphy", "Female", "b726a44e-f664-4d0a-acdc-a59fb86e98c0", new DateTime(2007, 11, 21, 9, 18, 3, 0, DateTimeKind.Unspecified), "Yes", "Torphy", "05394446513", "http://alexa.biz/up-sized", "Active", 3, "11082902605", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "Wales", (byte)33, new DateTime(1991, 10, 2, 21, 15, 23, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 5, 21, 42, 21, 0, DateTimeKind.Unspecified), "2610097b-10b0-492d-97dd-d4848bb92b2c", "143.113.40.44", "B", "Margot38@hotmail.com", new DateTime(2015, 5, 12, 19, 14, 39, 0, DateTimeKind.Unspecified), 5, "Alda", "AldaKuhic", "Male", "6f105756-a13e-48f7-ac2c-297e44f784c1", new DateTime(2014, 5, 12, 19, 14, 39, 0, DateTimeKind.Unspecified), "No", "Kuhic", "05122676461", "https://aurelia.info/deposit/personal-loan-account/awesome-granite-cheese", "Active", 5, "24105133989", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Scotland", (byte)45, new DateTime(1980, 3, 16, 15, 11, 14, 0, DateTimeKind.Unspecified), new DateTime(2012, 11, 17, 6, 37, 16, 0, DateTimeKind.Unspecified), "c218c1e9-86f8-4acb-9195-b4b5bab37c51", "115.226.84.45", "ADB", "Cole.Dicki@yahoo.com", new DateTime(2016, 10, 25, 17, 38, 9, 0, DateTimeKind.Unspecified), 3, "Shemar", "ShemarSchroeder", "764d5749-1ea8-4829-96eb-aa7ebb3b797c", new DateTime(2015, 10, 25, 17, 38, 9, 0, DateTimeKind.Unspecified), "No", "Schroeder", "05192020772", "http://jordi.com/licensed", 4, "29570268528", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractDrivers",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Wales", (byte)50, new DateTime(1974, 7, 7, 12, 13, 6, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 3, 45, 54, 0, DateTimeKind.Unspecified), "4c9a3b5c-85b7-4d8e-9b31-38a0da0f7bc5", "111.255.138.61", "ADB", "Mellie.Abbott@hotmail.com", new DateTime(2006, 8, 17, 10, 11, 28, 0, DateTimeKind.Unspecified), 1, "Winona", "WinonaWilliamson", "Male", "31039ce8-5f05-49fd-9582-f0e092928857", new DateTime(2005, 8, 17, 10, 11, 28, 0, DateTimeKind.Unspecified), "No", "Williamson", "05337986301", "http://brad.biz/array/bypassing", 1, "83214189125", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "England", (byte)39, new DateTime(1985, 6, 24, 3, 18, 6, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 5, 17, 37, 19, 0, DateTimeKind.Unspecified), "089a7d8b-f470-4928-a71c-a9a20a050436", "250.84.98.221", "Anahi.Yost@hotmail.com", new DateTime(2019, 1, 12, 1, 43, 30, 0, DateTimeKind.Unspecified), 3, "Gabriel", "GabrielKeebler", "Male", "a76fa050-53bc-44bd-8ef8-7243d6914648", new DateTime(2018, 1, 12, 1, 43, 30, 0, DateTimeKind.Unspecified), "No", "English", "Keebler", "05362103516", "http://aubrey.biz/web-services", "Passive", 3, "37756916503", null, null, null },
                    { 2, "Scotland", (byte)64, new DateTime(1960, 12, 3, 12, 41, 52, 0, DateTimeKind.Unspecified), new DateTime(2005, 12, 26, 2, 26, 22, 0, DateTimeKind.Unspecified), "da3056cf-ae94-4032-9d6c-36ed52f43034", "18.163.180.183", "Euna42@hotmail.com", new DateTime(2004, 5, 22, 15, 26, 19, 0, DateTimeKind.Unspecified), 3, "Gilda", "GildaRobel", "Female", "e105b366-a12a-4daf-8069-1109a7eabd69", new DateTime(2003, 5, 22, 15, 26, 19, 0, DateTimeKind.Unspecified), "No", "German", "Robel", "05978068698", "https://ayana.net/camp", "Passive", 1, "18661989394", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "FullName", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "Wales", (byte)34, new DateTime(1991, 2, 9, 21, 40, 44, 0, DateTimeKind.Unspecified), new DateTime(2013, 11, 18, 3, 52, 13, 0, DateTimeKind.Unspecified), "1ecd1c8b-c297-40ce-a9b9-9794c0090207", "35.249.246.125", "Anjali_OReilly99@hotmail.com", new DateTime(2002, 10, 16, 5, 38, 43, 0, DateTimeKind.Unspecified), 3, "Cristopher", "CristopherCollier", "1e8ac5f8-b3ff-4d88-a03f-819e8c830c73", new DateTime(2001, 10, 16, 5, 38, 43, 0, DateTimeKind.Unspecified), "No", "Italian", "Collier", "05644595393", "http://ben.name/navigate/zero-defect", 3, "57754268413", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Northern Ireland", (byte)65, new DateTime(1960, 1, 1, 8, 49, 52, 0, DateTimeKind.Unspecified), new DateTime(2004, 1, 15, 23, 29, 51, 0, DateTimeKind.Unspecified), "5e2bb1ad-52a5-4c4c-992c-61f3669ea01e", "20.29.165.167", "Hassie89@yahoo.com", new DateTime(2009, 8, 8, 8, 18, 10, 0, DateTimeKind.Unspecified), 2, "Bryce", "BryceEmard", "Female", "17b8a833-4167-4e71-9114-5739f2dbb6db", new DateTime(2008, 8, 8, 8, 18, 10, 0, DateTimeKind.Unspecified), "Yes", "English", "Emard", "05219573155", "https://royce.name/forint/gorgeous/ıncredible", 4, "69591936394", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractTourGuides",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "SubContractWorkerSupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Northern Ireland", (byte)37, new DateTime(1988, 1, 16, 17, 24, 52, 0, DateTimeKind.Unspecified), new DateTime(2015, 5, 11, 19, 29, 52, 0, DateTimeKind.Unspecified), "7b1114cd-329b-41a3-a271-33dfb8db1a19", "246.41.7.27", "Kenton.Moore4@gmail.com", new DateTime(2012, 3, 15, 22, 56, 47, 0, DateTimeKind.Unspecified), 4, "Wallace", "WallaceCasper", "Female", "e2645d29-3f0e-44a7-b25c-1ca4b29aea48", new DateTime(2011, 3, 15, 22, 56, 47, 0, DateTimeKind.Unspecified), "No", "Casper", "05235139205", "https://amanda.net/product/withdrawal/refined-concrete-car", "Passive", 3, "47226421073", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "England", (byte)42, new DateTime(1982, 11, 4, 20, 26, 23, 0, DateTimeKind.Unspecified), 5, 2, new DateTime(2021, 2, 16, 23, 44, 29, 0, DateTimeKind.Unspecified), "31d2caf4-8e4b-4bd4-821e-ea7167c0b3a8", "73.147.47.88", "Operations", 4170, "Torrey.Hilll98@gmail.com", new DateTime(2028, 11, 9, 23, 14, 14, 0, DateTimeKind.Unspecified), 5, "Elouise", "ElouiseRohan", "Female", "4ce7ea95-190d-45ab-9c4b-06f8f7f9d3df", new DateTime(2013, 11, 9, 23, 14, 14, 0, DateTimeKind.Unspecified), "No", "Rohan", "05179738725", "http://ken.biz/practical/soft", 3, "95965437624", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Northern Ireland", (byte)51, new DateTime(1973, 12, 18, 18, 31, 44, 0, DateTimeKind.Unspecified), 8, 5, new DateTime(2000, 8, 9, 11, 32, 49, 0, DateTimeKind.Unspecified), "df830b89-163a-493f-8c59-2c3e1573f3b2", "145.13.50.169", "Accounting", 7642, "Beau.Schoen@hotmail.com", new DateTime(2028, 5, 9, 7, 56, 25, 0, DateTimeKind.Unspecified), 23, "Alberto", "AlbertoPrice", "abe57566-05cc-4f59-bc59-fc99c8703527", new DateTime(2004, 5, 9, 7, 56, 25, 0, DateTimeKind.Unspecified), "No", "Price", "05049000722", "https://george.org/venezuela/withdrawal/forge", 5, "Active", "71914909029", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "Wales", (byte)30, new DateTime(1994, 11, 16, 2, 43, 16, 0, DateTimeKind.Unspecified), 7, 5, new DateTime(2011, 10, 8, 16, 24, 24, 0, DateTimeKind.Unspecified), "2da44c02-ba86-4a1e-88df-f833acb577cf", "192.238.234.132", "Operations", 6511, "Ward63@gmail.com", new DateTime(2028, 6, 14, 12, 58, 50, 0, DateTimeKind.Unspecified), 23, "Laurine", "LaurineWisoky", "Female", "ade51b22-a1ad-4e57-9d4e-92264fc7bd7f", new DateTime(2007, 6, 14, 12, 58, 50, 0, DateTimeKind.Unspecified), "No", "Wisoky", "05883654013", "https://napoleon.name/credit-card-account", 1, "Passive", "63980375554", null, null, null },
                    { 4, "Northern Ireland", (byte)35, new DateTime(1989, 4, 17, 23, 41, 12, 0, DateTimeKind.Unspecified), 6, 1, new DateTime(2018, 8, 21, 9, 11, 22, 0, DateTimeKind.Unspecified), "18ef83b1-c88a-41b6-8377-b0d01ab49f1a", "132.199.184.251", "Marketing", 5649, "Shane.Haag@gmail.com", new DateTime(2027, 10, 22, 18, 8, 12, 0, DateTimeKind.Unspecified), 11, "Gonzalo", "GonzaloPowlowski", "Female", "039e2eb8-64d8-4466-bc9a-13e0e9e5e610", new DateTime(2009, 10, 22, 18, 8, 12, 0, DateTimeKind.Unspecified), "No", "Powlowski", "05501029841", "https://charles.net/direct/vermont/generating", 2, "Passive", "33808852369", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "ResidenceRegionId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Northern Ireland", (byte)63, new DateTime(1961, 7, 4, 16, 58, 46, 0, DateTimeKind.Unspecified), 6, 2, new DateTime(2019, 12, 7, 13, 51, 16, 0, DateTimeKind.Unspecified), "116c7570-6c9d-4831-837c-786e1fb784a6", "117.94.5.69", "Marketing", 5311, "Kraig.Schowalter98@gmail.com", new DateTime(2028, 9, 26, 5, 17, 15, 0, DateTimeKind.Unspecified), 7, "Audie", "AudieJenkins", "Male", "fe33e053-e211-41b6-b93e-078b14ef19f3", new DateTime(2010, 9, 26, 5, 17, 15, 0, DateTimeKind.Unspecified), "No", "Jenkins", "05002786014", "https://randi.name/interfaces/bandwidth/stream", 4, "25459331282", null, null, null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventCategory", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new DateTime(2010, 4, 5, 15, 24, 26, 0, DateTimeKind.Unspecified), "86e45515-454a-45af-a304-4d0ee0936b50", "253.226.140.81", "6th generation Agent Planner markets online Programmable Soft Generic Granite Tuna", new DateTime(2010, 1, 6, 0, 44, 36, 0, DateTimeKind.Unspecified), "Safari", "dolorem", "f4979d8d-ec72-4db3-825c-1c8da1f6937c", "No", 5, new DateTime(2010, 1, 5, 22, 44, 36, 0, DateTimeKind.Unspecified), "Active", null, null, null },
                    { 2, new DateTime(2001, 8, 12, 15, 37, 21, 0, DateTimeKind.Unspecified), "3d03de4a-3fd1-4ccc-860b-00d7800d7302", "222.220.43.102", "override Parks Handcrafted Wooden Car e-business Specialist California Research neural-net", new DateTime(2012, 6, 6, 21, 22, 41, 0, DateTimeKind.Unspecified), "NightWalk", "odio", "a91e6fa5-1f8f-4f81-8b98-8e2810e4a8e0", "No", 4, new DateTime(2012, 6, 6, 17, 22, 41, 0, DateTimeKind.Unspecified), "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventCategory", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, new DateTime(2000, 11, 16, 23, 18, 49, 0, DateTimeKind.Unspecified), "262ca957-359c-4de3-b0d6-e521f4689da8", "71.69.128.55", "reboot sky blue International Incredible Rubber Chips calculating Surinam Dollar Avon Supervisor", new DateTime(2002, 8, 1, 7, 32, 45, 0, DateTimeKind.Unspecified), "Workshops", "optio", "dc9d32ed-30d1-4924-b575-8afe5b0f28cb", "Yes", 4, new DateTime(2002, 8, 1, 3, 32, 45, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventCategory", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, new DateTime(2010, 12, 20, 2, 12, 37, 0, DateTimeKind.Unspecified), "d7818a2c-2e97-49f6-aefb-40a1c0f1cf5e", "14.224.65.77", "payment task-force transmitting Nevada Automotive, Grocery & Baby Connecticut infrastructures optimizing", new DateTime(2014, 3, 27, 5, 10, 10, 0, DateTimeKind.Unspecified), "BeachParty", "vitae", "c1de4547-0e8f-4305-a3c8-baaa86e79191", "No", 2, new DateTime(2014, 3, 27, 3, 10, 10, 0, DateTimeKind.Unspecified), "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventCategory", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new DateTime(2010, 11, 15, 17, 18, 35, 0, DateTimeKind.Unspecified), "dfc830b2-2277-49ab-add2-cfeec0b6f167", "146.92.86.217", "Land Buckinghamshire Delaware emulation Ouguiya Legacy Costa Rican Colon Checking Account", new DateTime(2017, 8, 12, 18, 21, 39, 0, DateTimeKind.Unspecified), "BBQ_Camping", "mollitia", "b07e0ace-63eb-40bf-a976-62dc3b832113", "No", 2, new DateTime(2017, 8, 12, 14, 21, 39, 0, DateTimeKind.Unspecified), null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "Status", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new DateTime(2010, 2, 18, 6, 12, 19, 0, DateTimeKind.Unspecified), "e1d892ff-0945-4e7b-8b21-b2d8993edbc4", "96.174.206.191", "9b16551d-8f8e-4342-9243-a46a7d225224", "Yes", 1, "Active", 13432.289517350052000m, "Purchase", null, null, null },
                    { 2, new DateTime(2018, 1, 19, 12, 37, 2, 0, DateTimeKind.Unspecified), "03ec8077-b8d7-4645-ab54-182fa9d63eeb", "24.110.195.227", "3dcb1565-a017-494b-b5ab-8ca5ef8ae267", "No", 3, "Active", 1951.7584296330376000m, "Purchase", null, null, null },
                    { 3, new DateTime(2001, 7, 22, 1, 35, 10, 0, DateTimeKind.Unspecified), "09c43699-f5f1-4087-affa-cd1eae6ccfa1", "12.66.49.232", "194e9e3a-2326-4488-a7bd-f13809013964", "No", 1, "Passive", 13590.089077613334000m, "Sale", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, new DateTime(2015, 11, 24, 2, 8, 20, 0, DateTimeKind.Unspecified), "1244687f-d34f-4b33-9bf1-73ef9c977a0b", "225.245.159.80", "514666b0-8cae-43e7-ae53-a81c4380deac", "Yes", 4, 10930.682700149918000m, "Sale", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "Status", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new DateTime(2013, 5, 24, 9, 11, 30, 0, DateTimeKind.Unspecified), "6af0030b-9124-4789-bae3-454563b21fa3", "252.29.63.252", "78887177-ddf7-407f-a829-47f719bb2d23", "No", 5, "Active", 10394.408844726346000m, "Sale", null, null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "Guid", "IsUpdated", "ProductName", "ProductSupplierId", "Status", "UnitPrice", "UnitsInStock", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, 4, new DateTime(2007, 12, 21, 22, 55, 15, 0, DateTimeKind.Unspecified), "e521c6e1-5b92-4f07-8cf1-bfc69da7b102", "19.133.17.205", "unde rem nam blanditiis et autem", "4dc72b77-7280-40c4-a236-5127db0959f0", "No", "dolorumfacilisquasi", 1, "Active", 1059.8522f, (short)91, null, null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "Guid", "IsUpdated", "ProductName", "ProductSupplierId", "UnitPrice", "UnitsInStock", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, 4, new DateTime(2012, 8, 19, 18, 48, 13, 0, DateTimeKind.Unspecified), "3a793e4e-1075-4fa5-a2a4-7d62322d6c72", "162.52.134.91", "error officiis atque harum incidunt et", "97ef0ed7-70cf-41ef-9560-319dde4a5354", "Yes", "quasidelenitimagnam", 4, 153.90569f, (short)55, null, null, null },
                    { 3, 4, new DateTime(2009, 2, 1, 21, 36, 32, 0, DateTimeKind.Unspecified), "466ff6db-35b3-4bcc-93d4-87675b4b71aa", "208.59.152.92", "sint fugit et veritatis omnis error", "d149fb84-ec40-4c54-8430-86c7743c5512", "Yes", "totamdoloribuset", 4, 1055.9794f, (short)158, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "Guid", "IsUpdated", "ProductName", "ProductSupplierId", "Status", "UnitPrice", "UnitsInStock", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2002, 7, 11, 14, 23, 46, 0, DateTimeKind.Unspecified), "b21be265-5a3f-43a4-b4cb-48a3a72d95b9", "98.202.251.128", "qui aut et maxime voluptatem velit", "cf1c8e8a-0e98-4307-9de4-13e6734829f8", "No", "quidemreprehenderitenim", 3, "Active", 699.2146f, (short)71, null, null, null },
                    { 5, 3, new DateTime(2005, 8, 1, 7, 38, 9, 0, DateTimeKind.Unspecified), "7cf73774-1f00-4c0a-a883-ad9b4b9fb599", "183.215.204.49", "fugiat enim aliquid est libero laudantium", "f1bba5e0-1ebb-4f24-ba24-b88ab935171a", "No", "evenietlaborevoluptas", 3, "Active", 589.5799f, (short)145, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "TourCategory", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, new DateTime(2002, 10, 11, 2, 17, 19, 0, DateTimeKind.Unspecified), "380981b2-fe5a-48d0-9eb3-5718037ad998", "67.48.87.157", "Group networks JSON analyzing Licensed Rubber Gloves Rustic Plastic Tuna digital Garden", new DateTime(2013, 3, 8, 21, 47, 12, 0, DateTimeKind.Unspecified), "dolore", "bb6f35b8-a307-46cc-bf66-2bb4a53ace35", "No", 1, new DateTime(2013, 3, 8, 19, 47, 12, 0, DateTimeKind.Unspecified), "Active", "Waterfall", null, null, null });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "TourCategory", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, new DateTime(2011, 12, 13, 17, 16, 28, 0, DateTimeKind.Unspecified), "f6a29851-e064-4c6c-8dad-0989f8186e3d", "1.95.221.248", "Borders Rustic synthesize Fresh leverage Sri Lanka Rupee online Sleek", new DateTime(2002, 2, 1, 23, 59, 16, 0, DateTimeKind.Unspecified), "repudiandae", "8ac9f662-54c9-4a13-8674-4142bca2c9df", "No", 3, new DateTime(2002, 2, 1, 19, 59, 16, 0, DateTimeKind.Unspecified), "AquaPark", null, null, null },
                    { 3, new DateTime(2001, 5, 3, 9, 59, 20, 0, DateTimeKind.Unspecified), "fef59824-4ad2-4179-988b-e59abc033323", "119.68.75.168", "generate 24/7 Refined Frozen Pizza withdrawal Refined Plastic Keyboard synergy SCSI Concrete", new DateTime(2019, 8, 11, 5, 19, 33, 0, DateTimeKind.Unspecified), "numquam", "4eef6ab2-8593-4ca9-acd5-387f4794f000", "No", 3, new DateTime(2019, 8, 11, 2, 19, 33, 0, DateTimeKind.Unspecified), "Waterfall", null, null, null },
                    { 4, new DateTime(2009, 2, 3, 1, 49, 47, 0, DateTimeKind.Unspecified), "649d0b71-b4f9-4711-8f2e-663074ae1760", "69.247.139.206", "clicks-and-mortar Tasty Fresh Keyboard withdrawal Virtual GB Technician dot-com initiatives", new DateTime(2020, 7, 3, 23, 13, 23, 0, DateTimeKind.Unspecified), "debitis", "781779d1-ac1c-40e1-9d78-dadf2097596c", "No", 3, new DateTime(2020, 7, 3, 19, 13, 23, 0, DateTimeKind.Unspecified), "Cave", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "EventName", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "TourCategory", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new DateTime(2017, 4, 14, 17, 8, 15, 0, DateTimeKind.Unspecified), "b80f4ec5-cedb-4a3f-b9dc-5550fd50d70e", "197.109.133.127", "withdrawal leverage Small Wooden Car Illinois Bypass Sleek Cotton magenta", new DateTime(2011, 3, 7, 13, 17, 12, 0, DateTimeKind.Unspecified), "magni", "e6edaacf-de69-4cd5-886a-9763869bfd22", "No", 5, new DateTime(2011, 3, 7, 10, 17, 12, 0, DateTimeKind.Unspecified), "Active", "Cave", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "61227 Miller Expressway, Watsicafort, Slovenia", (byte)36, new DateTime(1988, 10, 6, 19, 10, 16, 0, DateTimeKind.Unspecified), new DateTime(2016, 9, 2, 23, 53, 44, 0, DateTimeKind.Unspecified), "6ba481b9-5f25-43b2-b474-532bcb6bf110", "102.206.232.251", "Oscar", "No", "Bergnaum", "lavon.com", "Passive", "10458570385", new DateTime(2024, 3, 16, 19, 36, 27, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "689 Blanda Fords, South Imogenetown, Botswana", (byte)73, new DateTime(1951, 11, 25, 21, 9, 36, 0, DateTimeKind.Unspecified), new DateTime(2013, 8, 23, 13, 46, 18, 0, DateTimeKind.Unspecified), "ea9ea95b-4e3f-43c7-87cc-7ab6732e1dbb", "78.191.12.189", "Dave", "Female", "No", "Schuppe", "granville.com", "91282742834", new DateTime(2024, 9, 10, 8, 9, 14, 0, DateTimeKind.Unspecified), null, null },
                    { 3, "1733 Ervin Brook, New Brisa, Jersey", (byte)63, new DateTime(1961, 10, 17, 20, 53, 30, 0, DateTimeKind.Unspecified), new DateTime(2014, 4, 6, 12, 36, 11, 0, DateTimeKind.Unspecified), "3031be05-561d-4658-9447-550e1bb38128", "171.138.76.186", "Rhoda", "Male", "Yes", "Jacobson", "sigrid.net", "88391886271", new DateTime(2023, 2, 21, 1, 58, 37, 0, DateTimeKind.Unspecified), null, null },
                    { 4, "60865 Gaston Falls, North Edison, Bosnia and Herzegovina", (byte)67, new DateTime(1957, 6, 10, 10, 12, 27, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 26, 21, 21, 36, 0, DateTimeKind.Unspecified), "542893e9-0948-43f1-9062-a6c24e21ba34", "116.177.128.127", "Rhoda", "Female", "Yes", "Nolan", "hayley.info", "52866187676", new DateTime(2023, 1, 23, 10, 16, 49, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "437 Collins Isle, Port Shanny, China", (byte)68, new DateTime(1957, 1, 12, 4, 45, 52, 0, DateTimeKind.Unspecified), new DateTime(2011, 4, 19, 19, 42, 30, 0, DateTimeKind.Unspecified), "1f4680c3-62a8-4eee-932c-791650edbb73", "71.21.25.194", "Claudie", "Male", "No", "Donnelly", "lola.com", "Active", "40724852362", new DateTime(2023, 9, 13, 13, 10, 15, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "EventTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[] { 1, new DateTime(2008, 6, 17, 22, 19, 30, 0, DateTimeKind.Unspecified), "d02f194d-1f1c-43c7-b803-37a3482a4c7c", "120.46.159.155", 3, "cb7ac8fc-027b-4380-8b8b-579ad1aabdf6", "No", "Refined Soft Shoes projection secured line Incredible Plastic Cheese", "Passive", null, null, null, 1, "Braden.Bashirian@hotmail.com" });

            migrationBuilder.InsertData(
                table: "EventTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[] { 2, new DateTime(2014, 8, 14, 7, 25, 8, 0, DateTimeKind.Unspecified), "fbbc8112-56e7-46c7-93c7-0e2ce483cb87", "21.161.71.135", 4, "d275173c-1a0a-49f9-9bac-6c839788e12a", "No", "morph Dynamic Global mint green", null, null, null, 3, "Allie.Kilback@hotmail.com" });

            migrationBuilder.InsertData(
                table: "EventTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[] { 3, new DateTime(2011, 12, 6, 14, 49, 34, 0, DateTimeKind.Unspecified), "67b5b8ed-7d48-4dc1-ba4e-bb3d1287eb9c", "165.222.245.87", 4, "43bd3bc7-354f-408b-a494-3f64e5065a9c", "No", "repurpose Avon foreground invoice", "Active", null, null, null, 3, "Crystal36@yahoo.com" });

            migrationBuilder.InsertData(
                table: "EventTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 4, new DateTime(2013, 9, 21, 20, 57, 50, 0, DateTimeKind.Unspecified), "7791b466-542b-4e3d-9e39-630a9022f5e5", "133.153.56.43", 5, "bc0534d9-6775-47d3-a2d9-a2f7cc354f33", "No", "Facilitator Surinam Dollar innovative access", null, null, null, 2, "Alexzander0@gmail.com" },
                    { 5, new DateTime(2021, 6, 26, 21, 14, 41, 0, DateTimeKind.Unspecified), "a596629a-0390-492e-8268-eaec50006b9c", "127.253.193.246", 3, "ef81deff-427e-4d85-9e80-59a174bd1d3f", "No", "e-enable eyeballs optical EXE", null, null, null, 1, "Isom.Kutch73@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EventTickets",
                columns: new[] { "Id", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "EventId", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "Status", "TicketName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, new DateTime(2017, 4, 20, 22, 17, 2, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 11, 29, 13, 0, DateTimeKind.Unspecified), "391e172c-028a-47ea-ac84-37614eabcd85", "179.151.175.110", "AED", "payment Checking Account", new DateTime(2017, 4, 20, 19, 17, 2, 0, DateTimeKind.Unspecified), "Rubber Mobility", (byte)12, 1, "474c142b-050b-4d76-9600-a3d58b29912a", "No", 192.2136491272692992m, "Pending", 218.424601280987840m, "D126", "Passive", "Naomi Collier", null, null, null });

            migrationBuilder.InsertData(
                table: "EventTickets",
                columns: new[] { "Id", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "EventId", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "TicketName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, new DateTime(2005, 9, 19, 7, 43, 6, 0, DateTimeKind.Unspecified), new DateTime(2018, 3, 8, 1, 46, 30, 0, DateTimeKind.Unspecified), "73c84065-b936-4f52-81a3-6193eddb386c", "22.41.10.246", "GBP", "Cotton Internal", new DateTime(2005, 9, 19, 4, 43, 6, 0, DateTimeKind.Unspecified), "Steel XML", (byte)18, 3, "a54f7acc-dbcc-4031-936b-248366950be7", "No", 198.1490903150065152m, "PartialPaid", 241.645232091471360m, "C202", "Shaina Jacobson", null, null, null },
                    { 3, new DateTime(2003, 7, 12, 10, 50, 5, 0, DateTimeKind.Unspecified), new DateTime(2006, 1, 18, 4, 21, 52, 0, DateTimeKind.Unspecified), "563c68a6-9e69-47e4-82d2-d5ae7e75f17c", "231.217.94.116", "CNY", "Orchestrator Graphical User Interface", new DateTime(2003, 7, 12, 7, 50, 5, 0, DateTimeKind.Unspecified), "compressing Administrator", (byte)20, 3, "774073ab-35d3-473d-92ed-237a7370cc64", "No", 226.283293494465024m, "PartialPaid", 282.854116868081280m, "B159", "Wanda Rodriguez", null, null, null },
                    { 4, new DateTime(2021, 7, 14, 17, 37, 51, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 22, 22, 17, 6, 0, DateTimeKind.Unspecified), "f6df4ba4-97c2-4b3c-af43-9ec50401161b", "53.50.130.127", "GBP", "Fiji Dollar Branch", new DateTime(2021, 7, 14, 14, 37, 51, 0, DateTimeKind.Unspecified), "optical synergies", (byte)12, 4, "279fe871-995e-4b63-9325-1496ebf7900d", "No", 322.5916421744912896m, "FullyPaid", 366.581411561921920m, "A100", "Ashlynn Cummings", null, null, null },
                    { 5, new DateTime(2021, 2, 9, 19, 59, 8, 0, DateTimeKind.Unspecified), new DateTime(2011, 10, 8, 21, 13, 42, 0, DateTimeKind.Unspecified), "8aab4627-bb0c-431a-800b-48b78c1c9f5b", "74.64.230.142", "USD", "Handcrafted Wooden Bike Lead", new DateTime(2021, 2, 9, 16, 59, 8, 0, DateTimeKind.Unspecified), "payment virtual", (byte)11, 1, "78bf018a-025d-42fa-bb81-caab13200bb1", "Yes", 152.6064062059078016m, "PartialPaid", 171.467872141469440m, "A13", "Madelyn Rowe", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PassEventTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, (byte)19, new DateTime(2010, 6, 20, 23, 57, 11, 0, DateTimeKind.Unspecified), "acceef2f-f347-4c68-967a-731661a80d87", "39.76.183.101", "356ec363-7d27-4c61-b63a-c64114e1ad0b", "No", 5, 190.296253783128320m, 226.4525420019227008m, null, null, null });

            migrationBuilder.InsertData(
                table: "PassEventTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, (byte)8, new DateTime(2019, 8, 23, 16, 42, 23, 0, DateTimeKind.Unspecified), "3ec33515-6cb6-423e-8380-d4b93ad46ebd", "101.213.159.160", "12ce5bae-8f88-4069-a817-43aed691c8e4", "Yes", 1, 119.2461381613053120m, "Active", 128.78582921420973696m, null, null, null },
                    { 3, (byte)10, new DateTime(2013, 2, 27, 17, 45, 2, 0, DateTimeKind.Unspecified), "2a72f855-c6c2-428c-8ad9-ffbff8baad11", "149.131.101.234", "8a4e841b-3fa1-47ba-8b4b-24a8f7b56c9b", "Yes", 1, 342.747966502669760m, "Active", 377.022763152936736m, null, null, null },
                    { 4, (byte)18, new DateTime(2002, 9, 1, 14, 23, 31, 0, DateTimeKind.Unspecified), "0714a519-94f9-4b89-990e-2f409fcf828c", "118.167.63.208", "e8cca25e-31fb-43ab-8892-b150f47fa163", "No", 2, 195.760724508205120m, "Active", 230.9976549196820416m, null, null, null },
                    { 5, (byte)9, new DateTime(2000, 11, 15, 15, 22, 24, 0, DateTimeKind.Unspecified), "e1282b75-ab22-4ffa-9e2d-4edc96023461", "157.227.208.117", "b062a0a5-d1af-41a5-aee0-0366963c0492", "No", 2, 215.67966946212800m, "Active", 235.09083971371952m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PassTourTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, (byte)7, new DateTime(2012, 9, 20, 3, 29, 50, 0, DateTimeKind.Unspecified), "15f4aaf5-1635-4337-b0b3-767f7274363c", "161.98.181.157", "1782ec60-049b-4eb1-8a34-5a2fb8d2b39f", "No", 3, 407.891461802152320m, 436.4438641283029824m, null, null, null });

            migrationBuilder.InsertData(
                table: "PassTourTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, (byte)10, new DateTime(2002, 5, 4, 21, 45, 19, 0, DateTimeKind.Unspecified), "198fd17b-3087-4d0a-a9d7-5fba65c84933", "245.234.152.174", "0b595120-77c0-4c77-bc32-eca1f1301fb0", "No", 2, 110.7495760461614720m, "Passive", 121.8245336507776192m, null, null, null },
                    { 3, (byte)10, new DateTime(2018, 10, 23, 21, 10, 40, 0, DateTimeKind.Unspecified), "be8722d5-e766-4822-92e4-80616714adf2", "34.117.232.46", "9cd77c5c-4b44-4ebd-8a15-74ea9f527a9e", "No", 5, 250.112161924491840m, "Passive", 275.123378116941024m, null, null, null },
                    { 4, (byte)6, new DateTime(2005, 3, 12, 5, 28, 38, 0, DateTimeKind.Unspecified), "7c6f10bf-09ab-445a-a36d-ec4b8ee551e7", "143.14.150.205", "02af24d7-7b35-4226-aab4-11e93957c4d9", "Yes", 2, 394.708075842975360m, "Passive", 418.3905603935538816m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PassTourTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, (byte)6, new DateTime(2004, 2, 10, 21, 48, 54, 0, DateTimeKind.Unspecified), "c3b0ff7f-4eba-46c3-8970-cad4bb73291d", "223.189.39.126", "4c851bea-9104-498e-9267-7d3c46752625", "No", 3, 207.997571281338560m, 220.4774255582188736m, null, null, null });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 1, new DateTime(2006, 6, 3, 8, 33, 29, 0, DateTimeKind.Unspecified), "5523bbc5-5166-4911-a80f-8c63ee510d28", "174.220.228.21", 3, "4d56bc20-1c69-430f-9974-83c4a82681fb", "No", "mobile Generic Granite Car Michigan Generic Plastic Fish", "Active", null, null, null, 1, "Katelyn.Weissnat16@yahoo.com" },
                    { 2, new DateTime(2001, 5, 1, 23, 38, 52, 0, DateTimeKind.Unspecified), "747003ed-b145-4919-a79f-5df752bef21c", "67.128.167.225", 1, "240e2539-4b91-4867-a8ec-9b3dae3f9e51", "No", "national withdrawal Mountains program", "Passive", null, null, null, 2, "Ansel47@gmail.com" },
                    { 3, new DateTime(2016, 7, 1, 15, 34, 5, 0, DateTimeKind.Unspecified), "55aded43-a8f4-4105-8139-64906066b03c", "120.234.73.131", 3, "8104253d-0362-4023-bd05-821c8786fde1", "Yes", "Industrial & Movies Kids & Automotive Plastic Corporate", "Passive", null, null, null, 2, "Karli64@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[] { 4, new DateTime(2003, 12, 6, 16, 44, 10, 0, DateTimeKind.Unspecified), "304c61c2-ee9e-44cd-9742-9f972d6d586e", "177.228.235.100", 1, "7edfe152-9e06-42f7-bbef-daf5de2d3ab2", "Yes", "disintermediate Guam Progressive withdrawal", null, null, null, 4, "Josephine84@yahoo.com" });

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[] { 5, new DateTime(2003, 9, 25, 2, 12, 35, 0, DateTimeKind.Unspecified), "327d19b6-29dc-4a35-9cfb-1604fc3c05c7", "136.53.195.24", 4, "9b9aebad-5ee0-4ccb-a6ee-a09ef4949933", "No", "primary Squares Germany override", "Active", null, null, null, 2, "Wilfrid29@yahoo.com" });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "EventId", "ExpireDate", "Guid", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "TotalPrice", "TotalRentalDay", "TourId", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 1, 12, (short)24, new DateTime(2019, 4, 20, 22, 9, 12, 0, DateTimeKind.Unspecified), "d81da796-d889-4cee-a402-c0d22f0a0c0c", "139.117.244.192", 16684m, 5, new DateTime(2001, 1, 10, 1, 21, 52, 0, DateTimeKind.Unspecified), "1942fdda-aef1-4efc-a2d0-7e3d21c851a0", "No", 627180, "62 jl 7063", "Beetle", 1, new DateTime(2001, 1, 6, 1, 21, 52, 0, DateTimeKind.Unspecified), 66736m, 4, 5, null, null, null, "Bus" });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "EventId", "ExpireDate", "Guid", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "TourId", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 2, 9, (short)41, new DateTime(2014, 9, 25, 13, 39, 29, 0, DateTimeKind.Unspecified), "9c8e4271-8ca4-4428-8053-bb078e282c6c", "66.117.128.148", 19186m, 1, new DateTime(2002, 1, 30, 18, 15, 10, 0, DateTimeKind.Unspecified), "59266388-0a3e-4736-b19a-1aa42d2fe6ab", "Yes", 419151, "13 yh 3165", "Grand Caravan", 1, new DateTime(2002, 1, 26, 18, 15, 10, 0, DateTimeKind.Unspecified), "Passive", 76744m, 4, 4, null, null, null, "Yacht" },
                    { 3, 5, (short)75, new DateTime(2007, 12, 10, 19, 34, 5, 0, DateTimeKind.Unspecified), "db545470-690f-4ff1-b872-d4bd63c4f566", "133.49.223.127", 21741m, 4, new DateTime(2013, 3, 16, 19, 25, 51, 0, DateTimeKind.Unspecified), "5815c0f3-8008-4c0a-8552-6c5904a6a005", "No", 708941, "17 iw 753", "Silverado", 5, new DateTime(2013, 3, 11, 19, 25, 51, 0, DateTimeKind.Unspecified), "Active", 108705m, 5, 2, null, null, null, "Bus" }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "EventId", "ExpireDate", "Guid", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "TotalPrice", "TotalRentalDay", "TourId", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 4, 2, (short)36, new DateTime(2018, 8, 4, 17, 20, 28, 0, DateTimeKind.Unspecified), "ece88878-4d39-4de3-9b79-ac8f47497f34", "180.34.109.205", 9226m, 2, new DateTime(2005, 12, 16, 4, 22, 53, 0, DateTimeKind.Unspecified), "ae871075-bade-4323-a0eb-bda430e5e014", "No", 596760, "7 xk 7659", "1", 3, new DateTime(2005, 12, 11, 4, 22, 53, 0, DateTimeKind.Unspecified), 46130m, 5, 5, null, null, null, "ATV" });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "EventId", "ExpireDate", "Guid", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "TourId", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 5, 2, (short)55, new DateTime(2013, 7, 21, 4, 39, 27, 0, DateTimeKind.Unspecified), "3ddc30d6-4c9d-4c4f-a125-b163dfe253b8", "249.183.77.86", 6987m, 2, new DateTime(2018, 10, 15, 1, 45, 37, 0, DateTimeKind.Unspecified), "5808ae49-a050-4d90-8139-224d4028fc0e", "No", 382793, "48 ac 8150", "Grand Cherokee", 3, new DateTime(2018, 10, 10, 1, 45, 37, 0, DateTimeKind.Unspecified), "Passive", 34935m, 5, 1, null, null, null, "ATV" });

            migrationBuilder.InsertData(
                table: "TourTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 1, new DateTime(2007, 8, 10, 9, 28, 44, 0, DateTimeKind.Unspecified), "76c0fe55-480d-4bc1-af2f-f207e2256bef", "235.44.246.172", 4, "60673d4a-046e-4e88-8248-d4b39e55174b", "No", "Grocery, Clothing & Baby Gorgeous Wooden Bacon Rubber indexing", "Passive", null, null, null, 2, "Kellie.Kerluke46@hotmail.com" },
                    { 2, new DateTime(2003, 3, 1, 9, 16, 31, 0, DateTimeKind.Unspecified), "47a949e7-b116-4b1d-8654-3cddc4d48063", "42.145.20.135", 2, "56fa24dd-d94f-493b-a61c-e721b984f50f", "No", "Awesome Concrete Chips Rustic Granite Cheese Money Market Account Incredible Cotton Cheese", "Passive", null, null, null, 2, "Jarred_Hodkiewicz94@gmail.com" },
                    { 3, new DateTime(2006, 3, 20, 15, 56, 50, 0, DateTimeKind.Unspecified), "68552977-45cb-44cb-b668-5afc8334dc84", "112.85.176.114", 4, "a85e3106-1aca-40f5-8dd9-a345108920a6", "No", "teal Ergonomic Plastic Shoes Granite transmitting", "Active", null, null, null, 3, "Monserrate10@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "TourTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 4, new DateTime(2006, 11, 3, 2, 14, 41, 0, DateTimeKind.Unspecified), "6d5bdfd6-cb16-4190-a594-4a34df192230", "208.33.203.24", 2, "ee48c2eb-8f1e-49c6-b002-39865229c8e0", "No", "violet Dynamic Terrace strategize", null, null, null, 4, "Miles68@gmail.com" },
                    { 5, new DateTime(2012, 10, 20, 16, 31, 33, 0, DateTimeKind.Unspecified), "1a61c5a9-05cc-417a-98a3-b5453b7eba40", "44.71.106.179", 1, "516527d6-4eb9-4115-a097-29667559e92a", "No", "monitor Garden Officer Auto Loan Account", null, null, null, 2, "Lily72@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "TourTickets",
                columns: new[] { "Id", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "Status", "TicketName", "TourId", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new DateTime(2006, 2, 8, 20, 54, 51, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 7, 13, 17, 23, 0, DateTimeKind.Unspecified), "b07080a4-515d-4a94-bc29-b560e0fb33f4", "213.145.198.131", "USD", "Shore Forint", new DateTime(2006, 2, 8, 13, 54, 51, 0, DateTimeKind.Unspecified), "Electronics & Tools Shoes & Clothing", (byte)14, "9e371213-c641-43f9-b7d1-f1e24b973a73", "No", 215.3375651614846208m, "Pending", 250.392517629633280m, "B86", "Active", "Kody Schroeder", 2, null, null, null },
                    { 2, new DateTime(2010, 10, 14, 8, 33, 7, 0, DateTimeKind.Unspecified), new DateTime(2014, 7, 26, 18, 50, 32, 0, DateTimeKind.Unspecified), "2d78fa51-0a08-47f3-bc22-ba6f5419322d", "64.222.28.188", "JPY", "Cambridgeshire Auto Loan Account", new DateTime(2010, 10, 14, 1, 33, 7, 0, DateTimeKind.Unspecified), "Port Gorgeous Frozen Shoes", (byte)17, "0816b448-4861-4f0e-a6f4-bf8278c87a6e", "No", 217.4178162371140864m, "Pending", 261.949176189294080m, "C176", "Passive", "Dixie Jast", 5, null, null, null },
                    { 3, new DateTime(2002, 7, 21, 4, 49, 5, 0, DateTimeKind.Unspecified), new DateTime(2009, 6, 26, 20, 56, 46, 0, DateTimeKind.Unspecified), "7e3ebefb-c9ec-455b-b2f9-b8374c2548c8", "197.67.87.33", "JPY", "solid state even-keeled", new DateTime(2002, 7, 20, 21, 49, 5, 0, DateTimeKind.Unspecified), "Sleek Metal Salad Handcrafted", (byte)19, "9436e3c9-86dc-401e-8072-70c0adb9e0d1", "No", 283.1569556851410048m, "Pending", 349.576488500174080m, "A197", "Passive", "Emmet Hintz", 2, null, null, null },
                    { 4, new DateTime(2006, 7, 17, 8, 42, 10, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 11, 17, 20, 35, 0, DateTimeKind.Unspecified), "d766f440-24db-4894-b1c2-6af8a6ab7d99", "221.76.137.33", "TRY", "Cotton Licensed", new DateTime(2006, 7, 17, 1, 42, 10, 0, DateTimeKind.Unspecified), "Planner Object-based", (byte)17, "5365275d-6891-4197-9943-e8a32b1b5c49", "Yes", 216.1586700715750816m, "FullyPaid", 260.432132616355520m, "D90", "Active", "Enrique Greenholt", 2, null, null, null },
                    { 5, new DateTime(2011, 8, 3, 21, 38, 42, 0, DateTimeKind.Unspecified), new DateTime(2002, 3, 7, 6, 17, 20, 0, DateTimeKind.Unspecified), "e96af050-a72e-4349-9849-cfb3ef6e1498", "173.182.191.50", "EUR", "deposit Markets", new DateTime(2011, 8, 3, 14, 38, 42, 0, DateTimeKind.Unspecified), "British Indian Ocean Territory (Chagos Archipelago) red", (byte)20, "93495f24-c51e-48f8-a99b-525cc955132e", "No", 96.8457561051688192m, "Pending", 121.0571951314610240m, "B136", "Passive", "Carlo Johns", 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "EventId", "Guid", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "Status", "TourId", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 1, 4, (short)38, new DateTime(2018, 5, 14, 23, 10, 40, 0, DateTimeKind.Unspecified), "97f09d15-45cd-4415-b889-f8faeb449351", "112.119.84.149", 1, "fca7fa72-3378-458f-9274-bcf6a3645d39", "No", 768603, "66 qj 8929", 14530896m, "Civic", new DateTime(2010, 1, 14, 23, 45, 34, 0, DateTimeKind.Unspecified), "Active", 5, null, null, null, "Sedan" },
                    { 2, 8, (short)40, new DateTime(2020, 3, 25, 11, 33, 8, 0, DateTimeKind.Unspecified), "2f0a4631-3bfe-4990-aa2a-66b56e118b21", "177.186.213.58", 4, "86cffca7-9c78-4777-8c26-fb6a63fe495f", "No", 413104, "58 gw 9454", 12280522m, "XC90", new DateTime(2019, 7, 7, 19, 14, 6, 0, DateTimeKind.Unspecified), "Passive", 3, null, null, null, "Bus" },
                    { 3, 6, (short)46, new DateTime(2020, 5, 11, 15, 15, 22, 0, DateTimeKind.Unspecified), "6e17f057-638a-4544-bd60-9d78eb80e653", "123.126.88.212", 1, "860f0fea-d3dc-4def-99a0-715ea3683119", "No", 689843, "40 jo 1229", 17525270m, "Explorer", new DateTime(2020, 11, 1, 12, 51, 45, 0, DateTimeKind.Unspecified), "Active", 4, null, null, null, "Jeep" },
                    { 4, 7, (short)31, new DateTime(2003, 6, 6, 22, 36, 16, 0, DateTimeKind.Unspecified), "08b7461e-3736-4a39-873b-dcf26bf4d87c", "100.204.37.13", 3, "ce74e440-2c7c-4e57-9e2f-d4a11c34ece4", "No", 104922, "36 zr 9502", 18203728m, "Model S", new DateTime(2002, 4, 26, 11, 29, 41, 0, DateTimeKind.Unspecified), "Active", 5, null, null, null, "ATV" },
                    { 5, 6, (short)49, new DateTime(2018, 9, 24, 7, 19, 31, 0, DateTimeKind.Unspecified), "1e76fd1b-9917-4699-82d9-d90cce68d53a", "117.3.222.75", 5, "0fce7689-856a-42fb-b4f8-5b925d4e078e", "Yes", 505125, "30 wj 2523", 9448913m, "A4", new DateTime(2017, 11, 2, 17, 22, 3, 0, DateTimeKind.Unspecified), "Active", 1, null, null, null, "Jeep" }
                });

            migrationBuilder.InsertData(
                table: "EventTicketOrderDetails",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "EventTicketId", "EventTicketOrderId", "Guid", "IsUpdated", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, new DateTime(2021, 2, 27, 7, 34, 31, 0, DateTimeKind.Unspecified), "0a21c12e-fb40-4ad5-b86a-525f4b950192", "124.254.16.0", 0.1733332052049205m, 1, 3, "2934d41d-5fd0-4418-a13d-53f1fd1150d6", "No", 3, 2006.5364854085789089322153108m, 809.087167099764200m, null, null, null });

            migrationBuilder.InsertData(
                table: "EventTicketOrderDetails",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "EventTicketId", "EventTicketOrderId", "Guid", "IsUpdated", "Quantity", "Status", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, new DateTime(2008, 1, 16, 20, 37, 29, 0, DateTimeKind.Unspecified), "165c9996-0479-48e9-b4eb-7e3230026d44", "89.144.33.250", 0.0751794662247765m, 3, 3, "8cf34846-f591-44fe-be6d-3df0b2092eb8", "Yes", 1, "Active", 264.41224794983419030941788745m, 285.906549750223500m, null, null, null },
                    { 3, new DateTime(2007, 1, 21, 7, 50, 24, 0, DateTimeKind.Unspecified), "c8cf0f25-e3e5-4739-a6f2-84d298dc8684", "185.230.58.97", 0.2728738006434890m, 3, 4, "ef476278-2e55-459d-bd99-cadbfaeee161", "No", 4, "Passive", 3330.7631527328649260800494590m, 1145.180560018504800m, null, null, null },
                    { 4, new DateTime(2003, 1, 9, 23, 19, 5, 0, DateTimeKind.Unspecified), "ab5f53b2-4198-4d45-9eb4-2610ad093298", "176.188.200.175", 0.2086681455572125m, 3, 5, "d13e2439-48c3-49a2-bf30-53d5ab1367af", "No", 4, "Active", 2234.1594991534200050849380861m, 705.822559337824400m, null, null, null },
                    { 5, new DateTime(2008, 11, 16, 7, 35, 48, 0, DateTimeKind.Unspecified), "56a22c82-9bf2-455c-8121-dacbbddc9eb9", "40.173.218.163", 0.1329951006008320m, 4, 4, "36937422-0188-4885-9cb1-ddcfce0b779b", "No", 4, "Active", 1083.6255082690739999157668463m, 312.462337012173600m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductOrderDetails",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "ProductId", "ProductOrderId", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new DateTime(2017, 9, 5, 8, 9, 26, 0, DateTimeKind.Unspecified), "cfd10f01-5103-41d6-ac5f-8ebdd6a03229", "227.90.240.56", 0.3305320098144885m, "0491d264-988e-468f-bf61-86aee8fb6134", "No", 3, 2, 4, 1860.8017121026311478866130335m, 694.88076330094500m, null, null, null },
                    { 2, new DateTime(2016, 9, 4, 15, 54, 34, 0, DateTimeKind.Unspecified), "2808dd28-bb0e-4464-baec-21a05f7649a0", "29.63.246.80", 0.0585227120251795m, "f7e592d4-ba54-401d-a9c8-792bd344107f", "No", 2, 5, 4, 2239.5747657567046943721979655m, 594.69697101620400m, null, null, null },
                    { 3, new DateTime(2014, 1, 22, 16, 25, 53, 0, DateTimeKind.Unspecified), "ab2a7502-c219-4895-9ad3-22abf250e241", "72.206.148.103", 0.3956900358219805m, "26b4f725-282a-444d-b873-a0a7d80cd800", "No", 1, 5, 4, 1364.6347965267566893326131151m, 564.542568143373500m, null, null, null },
                    { 4, new DateTime(2002, 9, 20, 10, 28, 54, 0, DateTimeKind.Unspecified), "00c9f685-7b5b-4493-b365-136d4d0b95e2", "108.90.21.242", 0.3361432196624215m, "f37e19d0-c3ff-46b1-af8d-44211d3a13a0", "No", 5, 1, 1, 326.46254890724935977528123396m, 491.766535458505900m, null, null, null },
                    { 5, new DateTime(2011, 10, 11, 23, 49, 29, 0, DateTimeKind.Unspecified), "ebb534c2-06f4-4825-b1be-d32135e6c38d", "106.233.130.199", 0.3935082933933835m, "f792e5af-2716-4467-b8c4-d3c8cbbfcb8f", "No", 2, 2, 2, 676.85440110554757685004653090m, 558.007960976595700m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "TourTicketOrderDetails",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "Status", "TotalCost", "TourTicketId", "TourTicketOrderId", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, new DateTime(2013, 7, 2, 4, 40, 49, 0, DateTimeKind.Unspecified), "b4e8e824-27e6-44e6-9430-cf69221296eb", "164.191.195.180", 0.04642936870278985m, "7aa3f425-0421-4c4d-bae2-88c8b778d7de", "No", 2, "Active", 1089.7897840481185348180880947m, 3, 3, 571.425832696629800m, null, null, null });

            migrationBuilder.InsertData(
                table: "TourTicketOrderDetails",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "TotalCost", "TourTicketId", "TourTicketOrderId", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, new DateTime(2018, 11, 25, 20, 35, 40, 0, DateTimeKind.Unspecified), "6dd82c3b-fbea-47d7-a013-b942688a3bf5", "131.55.164.183", 0.2576593794562355m, "9d8d67f3-3f41-41b4-b246-9efabe12a260", "No", 1, 812.6260926286018151857695228m, 3, 5, 1094.680891951397200m, null, null, null },
                    { 3, new DateTime(2014, 10, 2, 3, 8, 32, 0, DateTimeKind.Unspecified), "83abaaa5-0730-4273-abf3-c45fae86d915", "161.252.156.55", 0.4731660183422160m, "262398a4-23ae-403f-8d5a-35a24c2a57fd", "No", 3, 996.6904637810006890408034697m, 5, 3, 630.616410787020800m, null, null, null },
                    { 4, new DateTime(2018, 11, 27, 19, 18, 18, 0, DateTimeKind.Unspecified), "f59580b9-f6fd-4a4b-a908-36fef7678f78", "25.239.180.57", 0.01868928545370860m, "d01c95a1-f085-4748-8666-723b1aea4e72", "No", 1, 619.35070213285369202882131259m, 4, 5, 631.146376934455700m, null, null, null },
                    { 5, new DateTime(2021, 10, 17, 21, 21, 41, 0, DateTimeKind.Unspecified), "0069ad7f-d84c-4161-960b-fa3e48fb1e84", "79.104.55.248", 0.4176272710426985m, "c9f1620a-47d4-45b7-b615-b56cd75d4bf6", "No", 2, 458.76983169471037529065672732m, 4, 1, 393.879906186632700m, null, null, null }
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
                name: "EventTicketOrderDetails");

            migrationBuilder.DropTable(
                name: "PassEventTickets");

            migrationBuilder.DropTable(
                name: "PassTourTickets");

            migrationBuilder.DropTable(
                name: "ProductOrderDetails");

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
