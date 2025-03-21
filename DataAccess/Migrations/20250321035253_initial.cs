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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "451b1e23-c584-45bb-8ef8-0cfb7a3df6d9"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 546, DateTimeKind.Local).AddTicks(9268)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "4737acb7-5b02-422b-b24e-c06e83c5bccf"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "67ac02ae-7431-4db6-b9a9-29212a083d58"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 545, DateTimeKind.Local).AddTicks(6465)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e396d484-6d9d-4c53-a2e7-c7144c3329b1"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "034caad6-0fe8-4866-88e6-6dac1819aed9"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 551, DateTimeKind.Local).AddTicks(8692)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "66723c02-f119-4f6c-bdbf-30fa02033816"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "10c0763b-1021-43ba-ab5b-34fc1ad4ab3f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 545, DateTimeKind.Local).AddTicks(8882)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "dcbe0281-ab4f-4601-8424-81bdfa5382f8"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "65b1c45e-ebbe-4b83-9de8-4013a58af37d"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 546, DateTimeKind.Local).AddTicks(2020)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "435a6fb3-efd3-4883-8679-5d25c44e5528"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1152743b-ff88-4dc8-b06e-0d6e21fab6c0"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 552, DateTimeKind.Local).AddTicks(7807)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ccd009d8-7b84-4dd5-8963-71c24e8500c1"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "769fe984-4a8d-40e2-b057-012204f7b549"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 553, DateTimeKind.Local).AddTicks(1295)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "92dcc0d2-b1a2-48e2-b0b7-292b466cd26d"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1178fc44-4a77-4c9a-9fc1-5ace33a871f9"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 546, DateTimeKind.Local).AddTicks(5127)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0222b7f0-d683-4fae-b74c-16770372fc73"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "51e04581-ab0b-4110-99d3-18595d1fd00a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 556, DateTimeKind.Local).AddTicks(7066)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "761299d8-314c-463e-8324-e7b1c91eb898"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c188ec03-1ce8-4bbe-9a41-0769207fe48e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 552, DateTimeKind.Local).AddTicks(3009)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f8fe8b1a-9dff-45bb-b0b8-7113398efe26"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "575c80b7-82b8-41b4-a4ea-e7880b09a3a6"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 548, DateTimeKind.Local).AddTicks(2046)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "44aa6fc2-0f37-433d-8137-6e829fe4c3d4"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0639d9b6-b986-4b38-b300-002530f89615"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 544, DateTimeKind.Local).AddTicks(6182)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8d20264a-9094-4c28-96e5-35b814ff1736"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e9bcdfcf-3f45-47a4-ae4d-1bbd11752e13"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 545, DateTimeKind.Local).AddTicks(1428)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "16dcbf01-29ff-404f-8d27-e3122df48dea"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6e9e40dd-c729-4639-b6e4-34d95c3b2965"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 547, DateTimeKind.Local).AddTicks(2395)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "999539aa-548e-4b6f-b11b-25862165b4c1"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ea4528a3-aa74-48df-889c-1343fad603ab"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 547, DateTimeKind.Local).AddTicks(7686)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "49507083-a300-4578-a46d-9624634eed3f"),
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
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 557, DateTimeKind.Local).AddTicks(1879))
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
                name: "EventTicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cf400970-1cc6-4bd5-97cd-5b9787ff4a7e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 550, DateTimeKind.Local).AddTicks(8579)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c9f726be-83ed-4df9-b207-90d19a6160f9"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "dbbf697a-6936-49cc-b193-7138ab85e8e2"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 551, DateTimeKind.Local).AddTicks(1964)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5c42f0b5-6b33-4405-b58c-4430718f9138"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b7c14cf1-1dda-420c-a3fd-4e9af85f3cdf"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 551, DateTimeKind.Local).AddTicks(5374)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "fe1005c5-534a-478f-abd8-6bd835010560"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d6baa0d5-438f-4043-b9db-e0509e1c5b36"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 553, DateTimeKind.Local).AddTicks(4388)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7752f009-327b-4ec1-91e5-3802d53bd874"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "221edad9-b368-4e97-a4fb-661484de74bd"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 554, DateTimeKind.Local).AddTicks(136)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b26bb51f-ebb2-4d36-a30b-6922bb095473"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2e39e21d-49b4-40a5-a9e5-48a40312ec2b"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 553, DateTimeKind.Local).AddTicks(7229)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a89aaad2-586a-4217-a0af-a6195dde4f06"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b250fe86-7a01-45f4-8693-d65bc0e13faf"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 554, DateTimeKind.Local).AddTicks(4306)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e0c8bf03-ead6-44e7-b583-ce24f127755f"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0f59c683-aee6-4db0-88e2-23e47511f080"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 550, DateTimeKind.Local).AddTicks(902)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f6757e58-f185-492e-9da4-64dd98226358"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3a77a4fa-b8be-4d0e-aca8-f05bd24f2be2"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 549, DateTimeKind.Local).AddTicks(7155)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "06c5e49a-c0fe-46cb-ab3d-7942d2ed8421"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "86bc3bef-20a5-4190-aea6-7a77f23cc91c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 21, 6, 52, 53, 550, DateTimeKind.Local).AddTicks(4490)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e4c81f63-9239-45f3-a82b-634ff50a9923"),
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
                name: "PartnerCompanies");

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
