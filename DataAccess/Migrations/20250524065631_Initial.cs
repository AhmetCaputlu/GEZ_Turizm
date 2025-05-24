using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5a8691ea-d7a9-4ed4-a1ef-279babdb679f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 707, DateTimeKind.Local).AddTicks(9159)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "1a2bf5dc-bb72-4d66-9438-d3a141a4626f"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a1a0096b-ca8f-46dc-a3c1-556d03e66bdd"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 698, DateTimeKind.Local).AddTicks(2126)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "45712566-4ac4-41dc-a4af-98e9d6049732"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7ba9f666-6cd6-43d1-adce-80edc5e2e29e"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 704, DateTimeKind.Local).AddTicks(4113)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e4c50a8f-1f05-4bcb-a5df-12fff9ce865b"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "05a51ba7-1d9b-4920-85a1-4c5baf73502f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 719, DateTimeKind.Local).AddTicks(4914)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "7f229be3-69f4-49a4-b1da-9f9ce9738d91"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9bba904c-8c30-4948-b750-9db3888b05ae"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 706, DateTimeKind.Local).AddTicks(2037)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2b2eb69d-3a60-4506-a8ab-9d5efd5dcb8b"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 733, DateTimeKind.Local).AddTicks(710)),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "f7e7682a-6ffb-4012-969c-fbdd14bafe8c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 710, DateTimeKind.Local).AddTicks(7778)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "39f746d0-9d65-4de6-aa23-65c262f1cd31"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "b15d9816-7c88-4ae3-a396-7eafd95dc0db"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 699, DateTimeKind.Local).AddTicks(8505)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8071a790-ace0-467a-b93b-5727a080c284"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "9ebdc85b-360a-4224-9797-cd4b44d1ff61"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 696, DateTimeKind.Local).AddTicks(5090)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "59de98ac-8a8e-41b2-a028-b8a1b762f184"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "e037325b-baa4-49c4-91ad-5d1804b825d9"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 709, DateTimeKind.Local).AddTicks(3767)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "88b25614-39bf-495e-b95b-3aa3dc1fe8bb"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 31, 354, DateTimeKind.Local).AddTicks(1899)),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3ef11174-3bf3-4da9-8eeb-419e1faa748f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 716, DateTimeKind.Local).AddTicks(9690)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cfa562c9-c4ce-4caf-a6a9-a98922533f1d"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "0e1a7850-0e5b-4fa6-99ff-0721761c05ba"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 718, DateTimeKind.Local).AddTicks(2713)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c4206e1b-b1d2-4ef4-8e31-2f0322338c32"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "25f7ce7b-4262-43d8-889c-12ca6fdf4f5a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 720, DateTimeKind.Local).AddTicks(9598)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a6361d83-9d42-4949-90ea-85cc177ca98c"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c8cc423e-8063-4738-b264-31abd984e44a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 728, DateTimeKind.Local).AddTicks(9828)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "15e94cf2-9c85-4087-8f07-6ff4199c229a"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "963bff28-9248-4b7a-8038-dca8c1eb2290"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 730, DateTimeKind.Local).AddTicks(4618)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "921fbc20-f113-4e4e-8ad7-8493f832937e"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2c372605-01b6-4d15-9a54-0743faca5f52"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 24, 9, 56, 30, 715, DateTimeKind.Local).AddTicks(4777)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2b25df55-7689-4df4-bfa9-d4a79199f2c5"),
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
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "None", "TR", "Est velit iusto est fugiat assumenda.", "Turkey", "+90", new DateTime(2005, 2, 20, 11, 15, 20, 0, DateTimeKind.Unspecified), "582cd729-0a0f-4c52-9b29-9c76d20a53c9", "196.121.82.167", "7a218c9a-f1f3-42a1-bcac-107bf84baa54", "No", null, null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Australia", "RU", "Odit quibusdam impedit voluptate delectus blanditiis.", "Russia", "+7", new DateTime(2015, 4, 8, 12, 37, 25, 0, DateTimeKind.Unspecified), "1ee4fe3f-75a8-4ed1-afc1-2911e62a5a11", "81.218.168.184", "780c7190-9992-4c9c-827a-ee2acd1e5c2e", "No", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "SouthAmerica", "USA", "Qui ex ut ex facilis distinctio.", "United States of America", "+1", new DateTime(2008, 7, 8, 11, 28, 54, 0, DateTimeKind.Unspecified), "901ee7e1-54b5-4115-8b9b-e9692cc08f9a", "202.217.230.92", "75ad4917-f279-46e3-9bfc-37c3492caa25", "No", null, null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "None", "SA", "Sed aut ipsa ut ea incidunt.", "Kingdom of Saudi Arabia", "+966", new DateTime(2019, 6, 22, 20, 56, 11, 0, DateTimeKind.Unspecified), "7fdd4f3b-935d-45a6-a697-c8eec39d60ad", "56.19.18.179", "5b7df9ad-5872-4ce6-ae34-782324254fbe", "Yes", "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Europe", "GER", "Quod magnam voluptatem maxime delectus ut.", "Germany", "+49", new DateTime(2000, 5, 15, 13, 21, 50, 0, DateTimeKind.Unspecified), "1c86401c-3d86-457d-b34d-4efc33de9524", "19.12.217.184", "fee49919-d30a-4af9-8072-21312b7c8fde", "No", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Yes", "946 Gunner Junction, Luettgenport, Netherlands Antilles", -14261.808988722690000m, "Hirthe, Medhurst and White and Sons", "Amalia Mann", "Forward Web Producer", new DateTime(2007, 2, 1, 17, 50, 51, 0, DateTimeKind.Unspecified), "c49d1ffe-30d6-4214-9c6e-102f8d368d18", "79.88.111.169", 83654.328779559730000m, 69392.519790837040000m, "Tatum53@gmail.com", "8f0e2e6d-0b9c-4540-a760-774c0018290b", "No", "02151451520", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "Yes", "2861 Royce Causeway, Jacobsport, Morocco", 378.587414277180000m, "Wiegand, Deckow and Toy Inc", "Fay Considine", "National Division Producer", new DateTime(2000, 2, 25, 3, 43, 14, 0, DateTimeKind.Unspecified), "d9c2dd0c-8683-4429-a053-be64964bcd04", "18.101.72.76", 35310.798527375440000m, 35689.385941652620000m, "Millie_Legros@yahoo.com", "f688d527-399f-4289-aee5-2bab9c856e48", "No", "02139311126", "Passive", null, null, null },
                    { 3, "Yes", "747 Ellsworth Lock, Tristinland, Bangladesh", -19343.338572669660000m, "Jacobs, Haag and Rohan and Sons", "Murphy Schaden", "Dynamic Infrastructure Assistant", new DateTime(2003, 7, 3, 23, 41, 34, 0, DateTimeKind.Unspecified), "ba3fc251-8468-42d5-9bad-81d8e25129cb", "110.228.223.178", 70041.477854324350000m, 50698.139281654690000m, "Aaliyah.Fay95@yahoo.com", "b83f89e7-5011-48de-8411-03cf0df10460", "Yes", "02155915095", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Yes", "2180 Lueilwitz Garden, New Rachelburgh, Philippines", 17957.380730088240000m, "Gerlach, Christiansen and Bosco LLC", "Marquis Stanton", "Regional Optimization Facilitator", new DateTime(2016, 6, 7, 10, 49, 40, 0, DateTimeKind.Unspecified), "a64b59d5-0287-46ac-a0f0-4a9660638f53", "241.43.146.177", 60011.55513617950000m, 77968.935866267740000m, "Krystal.Cassin@hotmail.com", "a8180fac-55d2-406b-a5d1-be347331f24a", "No", "02140366937", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Yes", "073 Frederique Tunnel, Hilperthaven, Qatar", -34012.944826075800000m, "Rolfson, Williamson and Zboncak Group", "Nathanial Nienow", "Senior Brand Liaison", new DateTime(2018, 10, 13, 1, 38, 38, 0, DateTimeKind.Unspecified), "1bb102b8-e6db-4e3e-81d2-fc7b1972e3b5", "224.220.3.61", 88202.100684479320000m, 54189.155858403520000m, "Khalil69@gmail.com", "1bd5c33d-f512-4abb-92a8-0f4b23667c66", "No", "02102568262", "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "8131 McClure Overpass, Diegofort, Russian Federation", "Cummerata Inc and Sons", "Israel Blick", "Dynamic Factors Consultant", new DateTime(2020, 10, 6, 19, 27, 8, 0, DateTimeKind.Unspecified), "f35ed2cf-5a42-4a77-af7a-c2abf5975933", "181.143.234.18", "Lizzie.Stanton63@hotmail.com", "20b02f1d-e23b-40cd-bbd3-537d05e16a97", "No", "02145160037", "Passive", null, null, null },
                    { 2, "48397 Geoffrey Throughway, Osinskistad, Bhutan", "Renner Inc Inc", "Abe Douglas", "International Assurance Orchestrator", new DateTime(2009, 6, 12, 13, 24, 18, 0, DateTimeKind.Unspecified), "4c835ff2-80fb-4a18-8cc8-230f63871389", "162.85.206.136", "Lawson28@gmail.com", "3bc6dfc0-f36a-48a5-9c4a-4d3734c9e1dd", "No", "02130733685", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "07151 O'Kon Forges, Bayerfort, Mongolia", "Hansen, Hane and Stanton Group", "Adrien Lebsack", "Direct Response Architect", new DateTime(2001, 9, 9, 1, 39, 31, 0, DateTimeKind.Unspecified), "2992b0a1-df42-4315-843f-19b74946ee92", "81.13.219.135", "Verda_Stiedemann58@yahoo.com", "dd23c1cc-7155-4c1b-b713-18f9a1397020", "No", "02147277962", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "617 Hilpert Avenue, Colestad, Lithuania", "Thompson - Klocko Inc", "Laverne Rutherford", "Human Configuration Analyst", new DateTime(2021, 2, 3, 2, 31, 38, 0, DateTimeKind.Unspecified), "5ce2e088-b85d-4cf6-97ea-7dd12d182e06", "61.71.152.184", "Scottie3@hotmail.com", "3065e47d-9ba5-4b11-b357-4c87ea6d8e69", "No", "02125200532", "Passive", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "007 Beier Drive, West Sonia, Sri Lanka", "Block, Haag and Anderson Inc", "Ernestine Stanton", "Legacy Implementation Engineer", new DateTime(2019, 12, 21, 7, 9, 40, 0, DateTimeKind.Unspecified), "f8be263b-4019-4c70-ade3-66659ea2d3ec", "186.132.193.95", "Rocio.Kassulke70@hotmail.com", "70f17a85-ed01-422d-9059-42504ff1adba", "No", "02173952431", null, null, null });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "Status", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 1, 24, 0, 0), new DateTime(2019, 4, 9, 14, 16, 52, 0, DateTimeKind.Unspecified), "b6b4b9e4-ff3e-49e8-bd71-5fe3dbcf284d", "96.234.105.75", "fuga", "effce242-feed-4977-a26b-5d28620b0dfe", "Yes", "No", "No", "Active", "No", 7, null, null, null },
                    { 2, new TimeSpan(0, 2, 36, 0, 0), new DateTime(2016, 3, 1, 10, 37, 27, 0, DateTimeKind.Unspecified), "8babeead-35dd-4e49-a866-9f24049c2328", "111.112.26.209", "sint", "c9ec0eaf-130c-404d-b818-7dbb8b6eab3b", "Yes", "Yes", "No", "Passive", "No", 4, null, null, null },
                    { 3, new TimeSpan(0, 1, 39, 0, 0), new DateTime(2013, 11, 22, 9, 43, 50, 0, DateTimeKind.Unspecified), "f351aa3a-1adf-4a4f-b6aa-57dc4e1863f3", "228.49.187.227", "in", "efa4e1fc-1bca-47ca-b7d2-288d2ece5788", "Yes", "No", "No", "Passive", "Yes", 3, null, null, null },
                    { 4, new TimeSpan(0, 1, 55, 0, 0), new DateTime(2014, 2, 20, 4, 39, 8, 0, DateTimeKind.Unspecified), "9880d9f7-d7d6-48bd-ab3b-6b8a7a4f1959", "92.212.141.94", "quaerat", "90af5d3d-c256-497b-b715-aa73bf809e23", "No", "No", "No", "Passive", "Yes", 4, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new TimeSpan(0, 0, 52, 0, 0), new DateTime(2011, 3, 7, 17, 32, 48, 0, DateTimeKind.Unspecified), "8cc79c38-c9cf-4bd8-b4a4-31db381e58b8", "241.183.36.245", "earum", "9ecc6849-8006-471e-ac4f-06981af8886a", "Yes", "No", "Yes", "Yes", 4, null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "902 Juliet Loaf, Bryonburgh, American Samoa", "Murphy LLC LLC", "Esperanza Wintheiser", "Product Functionality Specialist", new DateTime(2002, 9, 9, 17, 33, 54, 0, DateTimeKind.Unspecified), "0a40c467-7633-44e7-a356-84a3bd25e296", "238.232.52.47", "Ruben.Pacocha@gmail.com", "c8cd2be1-a384-49cb-9642-afc79b814f94", "No", "02144880789", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "6553 Daugherty Ports, Roxanehaven, Holy See (Vatican City State)", "Jacobi, Wyman and Ortiz and Sons", "Abelardo Marvin", "Central Brand Assistant", new DateTime(2002, 8, 2, 21, 18, 18, 0, DateTimeKind.Unspecified), "505a8000-7fba-48b0-be9f-e372678b6f19", "34.196.66.16", "Eunice_Tromp@yahoo.com", "641db359-9f5d-4cb8-b0d1-d4821041e176", "No", "02186447217", "Passive", null, null, null },
                    { 3, "982 Kamille Mall, Jeffereyhaven, Turkmenistan", "Flatley - Emard Group", "Luis Mante", "Future Accounts Designer", new DateTime(2016, 5, 7, 20, 38, 10, 0, DateTimeKind.Unspecified), "c97ec3d6-029a-4f0b-9f08-317f912e6f29", "252.122.190.67", "Jeffery88@hotmail.com", "c3729fb6-3a85-4652-bb2f-0676cc39b524", "No", "02139824678", "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "7700 Jessie Stravenue, Ratkemouth, Albania", "Lowe, Breitenberg and Bashirian LLC", "Fannie Schowalter", "Principal Accounts Orchestrator", new DateTime(2009, 7, 14, 8, 53, 6, 0, DateTimeKind.Unspecified), "3ce48c17-0775-4595-8e29-ce0f41ce669c", "154.227.150.217", "Rudolph.Stehr83@hotmail.com", "897dd6a9-3f13-4a94-b59a-0c17c662b427", "No", "02111859183", null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "096 Connelly Village, Effertzfurt, Isle of Man", "Veum - Price Group", "Maria Ziemann", "Dynamic Web Architect", new DateTime(2000, 11, 5, 17, 35, 34, 0, DateTimeKind.Unspecified), "ba8d442f-c486-4483-b06c-bbf9a36a7803", "81.50.59.42", "Kailyn.Swift35@gmail.com", "af8e2f1b-5c86-4041-b9b9-e225f2af70ba", "No", "02182166882", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Cave", "inventore", new DateTime(2011, 3, 9, 17, 52, 15, 0, DateTimeKind.Unspecified), "6f8f01cc-5bc7-4c35-af65-e7b089b34ff6", "65.143.173.14", "Frozen Guinea Franc Licensed Concrete Pants Incredible Granite Pants cyan Integration frictionless microchip", new DateTime(2020, 5, 23, 21, 11, 10, 0, DateTimeKind.Unspecified), "3d674a23-3522-44a4-b481-468e0b0cad76", "Yes", 4, new DateTime(2020, 5, 23, 10, 11, 10, 0, DateTimeKind.Unspecified), "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "Castle", "maxime", new DateTime(2006, 5, 12, 2, 36, 42, 0, DateTimeKind.Unspecified), "953b53ec-1d85-402c-978c-9d6761bc9f7d", "119.41.20.107", "Djibouti Fresh Home & Automotive protocol New Taiwan Dollar Vision-oriented firewall Greens", new DateTime(2001, 11, 14, 16, 14, 31, 0, DateTimeKind.Unspecified), "25ddb7c1-b142-4ba5-b273-7a1a31c7356e", "Yes", 1, new DateTime(2001, 11, 14, 7, 14, 31, 0, DateTimeKind.Unspecified), null, null, null },
                    { 3, "ReligiousStructure", "quo", new DateTime(2015, 2, 3, 9, 26, 35, 0, DateTimeKind.Unspecified), "fbab6de0-3eaa-4c50-aa5b-d57e612fcca8", "179.251.90.131", "bus program Shore Bolivia Rustic Wooden Fish synthesizing hacking South Carolina", new DateTime(2009, 11, 11, 22, 12, 14, 0, DateTimeKind.Unspecified), "f3f7d63d-c843-4ea1-b129-05bc0df32b14", "Yes", 3, new DateTime(2009, 11, 11, 15, 12, 14, 0, DateTimeKind.Unspecified), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "NightWalk", "voluptatem", new DateTime(2006, 12, 3, 23, 50, 34, 0, DateTimeKind.Unspecified), "fed15db4-2dee-4366-a799-10c6aeb0c2c3", "130.253.184.245", "Dynamic Sports & Sports Cambridgeshire value-added upward-trending IB web-readiness Buckinghamshire", new DateTime(2006, 6, 28, 3, 26, 50, 0, DateTimeKind.Unspecified), "075493c3-878f-4af8-b6f0-8ac248b28eb8", "No", 1, new DateTime(2006, 6, 27, 18, 26, 50, 0, DateTimeKind.Unspecified), "Passive", null, null, null },
                    { 5, "Meditation", "iste", new DateTime(2001, 3, 4, 19, 17, 30, 0, DateTimeKind.Unspecified), "ba261008-3b76-45a1-8b3c-cd6cfd17db52", "148.131.162.129", "solution programming Savings Account Chief Handmade Massachusetts action-items Guinea Franc", new DateTime(2012, 10, 6, 5, 29, 20, 0, DateTimeKind.Unspecified), "55b5ca03-15f5-4969-9146-64b1475294a1", "No", 2, new DateTime(2012, 10, 5, 20, 29, 20, 0, DateTimeKind.Unspecified), "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "2a2d13a4-7416-4ba6-a914-6e5d9f699ec2", 1, new DateTime(2021, 10, 21, 14, 56, 33, 0, DateTimeKind.Unspecified), "ae9d7c29-b4fa-466e-ab96-6b33c65276cb", "24.95.229.172", "Riley.Swaniawski25@yahoo.com", false, "3b60110f-e179-48cd-a378-247ca982efa1", "Yes", false, new DateTimeOffset(new DateTime(2025, 5, 31, 9, 56, 30, 856, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 3, 0, 0, 0)), "RİLEY.SWANİAWSKİ25@YAHOO.COM", "EMİLİANO", "$2a$11$YWzGZMIJbKr/48KHwxa1l.jKfvIuF9I2lyeUytCPK1ILsic3hJ4Em", "05269116670", false, null, false, null, null, null, "Emiliano" },
                    { 2, 0, "3595bdbe-e04f-4446-9749-15e78ca14aa9", 4, new DateTime(2021, 5, 7, 12, 16, 52, 0, DateTimeKind.Unspecified), "4840edd3-513a-46a1-830e-5d2ff68f9c7c", "216.215.243.121", "Justina_Emmerich56@hotmail.com", false, "c65c266e-6ccc-4422-9e84-99dd98a4f36f", "Yes", false, new DateTimeOffset(new DateTime(2025, 5, 31, 9, 56, 30, 979, DateTimeKind.Unspecified).AddTicks(4957), new TimeSpan(0, 3, 0, 0, 0)), "JUSTİNA_EMMERİCH56@HOTMAİL.COM", "CAROLE", "$2a$11$zFPuGtsHRL1.E.Puu9Wc4ejqaenkj3la1dT3OisWGX8Heoono8vLe", "05866281339", false, null, false, null, null, null, "Carole" },
                    { 3, 0, "20f19c84-6fed-40eb-b822-65a042c4ccc6", 5, new DateTime(2011, 1, 3, 2, 20, 5, 0, DateTimeKind.Unspecified), "64bf711c-7676-48a3-9280-9d5b5010cd2c", "1.109.71.171", "Madaline.Skiles@yahoo.com", false, "28ee6286-46e6-415c-956a-465c25ed7f34", "No", false, new DateTimeOffset(new DateTime(2025, 5, 31, 9, 56, 31, 103, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 3, 0, 0, 0)), "MADALİNE.SKİLES@YAHOO.COM", "WİNNİFRED", "$2a$11$AouaPzlhZ0t1JY51IfD/qO/bag/w7SqNfsv7liaKoV9mU.OJFEMpi", "05968716777", false, null, false, null, null, null, "Winnifred" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 4, 0, "7a9c6bb6-ecd2-47e0-b9d8-5661c3824ce5", 5, new DateTime(2007, 6, 4, 3, 39, 43, 0, DateTimeKind.Unspecified), "f7a41cd1-71d7-4bf7-bbbe-72ee90b5b099", "254.209.105.213", "Nannie_Konopelski61@hotmail.com", false, "3c100f18-9bca-4f1e-9249-bec0df72fa51", "No", false, new DateTimeOffset(new DateTime(2025, 5, 31, 9, 56, 31, 229, DateTimeKind.Unspecified).AddTicks(185), new TimeSpan(0, 3, 0, 0, 0)), "NANNİE_KONOPELSKİ61@HOTMAİL.COM", "JANET", "$2a$11$4AaHOy97NSopTJeS.NhUbeZuZEFzd1Q/YtYGOMkkJP.0mYnc8myW.", "05652338139", false, null, "Passive", false, null, null, null, "Janet" },
                    { 5, 0, "19ae802c-1e8d-4fb0-aa63-e3b7f467ea8d", 2, new DateTime(2015, 7, 15, 8, 35, 40, 0, DateTimeKind.Unspecified), "b858cbce-d13f-49b3-9770-e945e2a359d9", "151.220.217.7", "Bernie_Willms@hotmail.com", false, "1e2b5bb0-01e1-46f9-977d-a158a19a9ccb", "Yes", false, new DateTimeOffset(new DateTime(2025, 5, 31, 9, 56, 31, 353, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, 3, 0, 0, 0)), "BERNİE_WİLLMS@HOTMAİL.COM", "MADDİSON", "$2a$11$lF0vopbDwGJZlm0bxWM50eQi2mspbbRT1sZ33zFx7K/796gDuxwsC", "05289779450", false, null, "Active", false, null, null, null, "Maddison" }
                });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "England", (byte)43, new DateTime(1981, 10, 17, 19, 8, 34, 0, DateTimeKind.Unspecified), new DateTime(2008, 3, 5, 8, 40, 26, 0, DateTimeKind.Unspecified), "8ea5397e-5451-41ad-a85c-b366fbb60997", "63.16.69.213", "B", "Rene67@gmail.com", new DateTime(2022, 12, 21, 22, 29, 8, 0, DateTimeKind.Unspecified), 5, "Catharine", "CatharineLittel", 2, "93223d87-1b10-42ed-8e54-960baebc1e23", new DateTime(2021, 12, 21, 22, 29, 8, 0, DateTimeKind.Unspecified), "No", "French", "Littel", "05341577364", "https://odell.info/locks/corporate", 4, "64617652742", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "Scotland", (byte)36, new DateTime(1988, 8, 12, 13, 36, 29, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 22, 20, 47, 13, 0, DateTimeKind.Unspecified), "5a9015ab-6b02-4816-8dec-7a97ff24a98b", "105.11.230.213", "None", "Pearl.Walsh58@gmail.com", new DateTime(2001, 2, 27, 2, 9, 3, 0, DateTimeKind.Unspecified), 4, "Donna", "DonnaBogisich", 1, "0e947518-75c1-422e-a403-03c96c1cbfa7", new DateTime(2000, 2, 27, 2, 9, 3, 0, DateTimeKind.Unspecified), "No", "Spanish", "Bogisich", "05736930024", "http://kylee.biz/contingency", "Passive", 4, "30016579933", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "England", (byte)33, new DateTime(1991, 6, 15, 11, 59, 25, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 10, 11, 57, 26, 0, DateTimeKind.Unspecified), "455f86fb-9ce4-4017-b48b-7d03314d80f7", "84.144.234.13", "D", "Duane74@gmail.com", new DateTime(2010, 7, 24, 19, 26, 31, 0, DateTimeKind.Unspecified), 5, "Layne", "LayneRau", 1, "40c7fdd9-3d2b-40ea-80e6-3fbeb0c0a0a2", new DateTime(2009, 7, 24, 19, 26, 31, 0, DateTimeKind.Unspecified), "No", "Spanish", "Rau", "05250326115", "http://lea.biz/ıb/turnpike", 2, "68289163700", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "England", (byte)54, new DateTime(1971, 3, 10, 20, 51, 44, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 14, 6, 52, 16, 0, DateTimeKind.Unspecified), "e877a8fc-5fbf-4355-b9aa-3a5a1bd8e5ad", "161.233.139.165", "D", "Marlin.Blick25@yahoo.com", new DateTime(2019, 10, 22, 14, 11, 26, 0, DateTimeKind.Unspecified), 5, "Janie", "JanieKlein", 0, "ab00ac7f-1926-4b07-b062-5df4e04d9378", new DateTime(2018, 10, 22, 14, 11, 26, 0, DateTimeKind.Unspecified), "No", "Arabic", "Klein", "05580375408", "https://corene.org/portals/iterate", "Active", 4, "81251255355", null, null, null },
                    { 5, "Wales", (byte)55, new DateTime(1970, 3, 7, 2, 22, 21, 0, DateTimeKind.Unspecified), new DateTime(2004, 6, 15, 8, 23, 10, 0, DateTimeKind.Unspecified), "d51473f7-fe83-4e85-8319-e7a3304f511c", "204.193.222.119", "None", "Malachi_Larson10@hotmail.com", new DateTime(2002, 7, 11, 14, 8, 47, 0, DateTimeKind.Unspecified), 5, "Frankie", "FrankieStroman", 1, "f14e4955-ed56-46e1-b92c-21b9607fd0dd", new DateTime(2001, 7, 11, 14, 8, 47, 0, DateTimeKind.Unspecified), "No", "Arabic", "Stroman", "05300651762", "https://mason.info/generic-rubber-fish/toys", "Passive", 3, "62950119714", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Scotland", (byte)54, new DateTime(1971, 4, 25, 18, 18, 13, 0, DateTimeKind.Unspecified), 2, 3, new DateTime(2018, 9, 24, 4, 38, 36, 0, DateTimeKind.Unspecified), "6dbfd465-04fe-4ef1-ad49-a68749c393f0", "166.120.154.39", "Accounting", 1796, "Reuben_Mueller@gmail.com", new DateTime(2026, 6, 22, 18, 25, 5, 0, DateTimeKind.Unspecified), 8, "Kayla", "KaylaDenesik", "Male", "b704755e-3bcc-46e6-8be2-e5001bb89552", new DateTime(2020, 6, 22, 18, 25, 5, 0, DateTimeKind.Unspecified), "No", "Denesik", "05104651329", "https://beryl.name/seize/grey/5th-generation", "02471968390", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "England", (byte)33, new DateTime(1991, 8, 17, 8, 52, 31, 0, DateTimeKind.Unspecified), 8, 3, new DateTime(2013, 4, 6, 11, 58, 36, 0, DateTimeKind.Unspecified), "41fc8074-d460-41a4-86fa-f70461fd383a", "109.20.170.54", "Operations", 7575, "Gay_Turcotte@hotmail.com", new DateTime(2028, 8, 26, 11, 58, 28, 0, DateTimeKind.Unspecified), 11, "Daniela", "DanielaOlson", "Female", "9471c26b-cd83-4f33-99d9-ad63483b153c", new DateTime(2004, 8, 26, 11, 58, 28, 0, DateTimeKind.Unspecified), "No", "Olson", "05940039219", "http://randi.name/luxembourg/ıntuitive", "Passive", "25035349133", null, null, null },
                    { 3, "England", (byte)51, new DateTime(1974, 4, 6, 8, 19, 47, 0, DateTimeKind.Unspecified), 5, 5, new DateTime(2008, 10, 18, 1, 18, 20, 0, DateTimeKind.Unspecified), "a6b976c5-e95e-4a6b-aeda-a2ade7defa37", "52.65.102.97", "Accounting", 5038, "Clark.Aufderhar@yahoo.com", new DateTime(2026, 8, 8, 6, 18, 54, 0, DateTimeKind.Unspecified), 19, "Friedrich", "FriedrichLynch", "Male", "0a7b2a33-ada5-4a9a-9e92-84fd613bd83b", new DateTime(2011, 8, 8, 6, 18, 54, 0, DateTimeKind.Unspecified), "No", "Lynch", "05815925353", "https://harvey.com/sas", "Passive", "48590176489", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, "Scotland", (byte)32, new DateTime(1992, 9, 21, 1, 15, 15, 0, DateTimeKind.Unspecified), 2, 3, new DateTime(2005, 1, 4, 4, 17, 5, 0, DateTimeKind.Unspecified), "5891c39d-f758-461c-8711-20376c9a2d68", "228.162.30.249", "Accounting", 1688, "Reina.Schuppe45@hotmail.com", new DateTime(2026, 10, 8, 16, 57, 14, 0, DateTimeKind.Unspecified), 12, "Jude", "JudeWest", "Female", "09514cdc-9b0e-4543-9cb4-113863a49e0a", new DateTime(2020, 10, 8, 16, 57, 14, 0, DateTimeKind.Unspecified), "No", "West", "05332191033", "https://lela.info/fantastic", "33811466563", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "Scotland", (byte)51, new DateTime(1974, 2, 7, 8, 57, 12, 0, DateTimeKind.Unspecified), 9, 5, new DateTime(2009, 1, 14, 14, 35, 28, 0, DateTimeKind.Unspecified), "bc17baf5-dae2-4c4d-b182-6fb125c0ea38", "93.205.159.102", "Marketing", 8886, "Nasir66@hotmail.com", new DateTime(2028, 1, 23, 22, 29, 30, 0, DateTimeKind.Unspecified), 24, "Rico", "RicoOsinski", "Male", "c135939e-a951-40ff-8624-1a32e206c799", new DateTime(2001, 1, 23, 22, 29, 30, 0, DateTimeKind.Unspecified), "No", "Osinski", "05489576010", "http://bo.net/ıncredible-steel-ball/object-oriented/music", "Active", "09107927563", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "Status", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 3, 22, 1, 28, 10, 0, DateTimeKind.Unspecified), "20a9aba4-5270-44a9-9387-60f6ea10d940", "5.220.233.132", "44708b98-0d25-4013-a1b5-608097954d50", "No", 2, "Passive", 7574.299482215878000m, "Sale", null, null, null },
                    { 2, new DateTime(2003, 9, 18, 6, 52, 51, 0, DateTimeKind.Unspecified), "bb1388a1-9461-4876-8696-a850d5ca4b1c", "190.67.102.17", "977f7866-0255-4af4-8b63-36c8dc850a57", "No", 3, "Active", 1454.7429944368696000m, "Sale", null, null, null },
                    { 3, new DateTime(2002, 1, 11, 1, 31, 36, 0, DateTimeKind.Unspecified), "53880bc6-1c77-488e-abff-2d276e17fd56", "158.130.200.24", "94c9902b-a4c8-4b8a-ba3e-148e93aef350", "No", 4, "Passive", 12628.270465738864000m, "Sale", null, null, null },
                    { 4, new DateTime(2014, 11, 14, 23, 45, 45, 0, DateTimeKind.Unspecified), "b7590e99-f2d6-456b-9007-ac3403795fa7", "99.153.48.160", "5d3a4d4c-db0b-460e-8568-3c14a354c445", "No", 4, "Passive", 1484.2432382800698000m, "Sale", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new DateTime(2012, 5, 10, 8, 24, 27, 0, DateTimeKind.Unspecified), "3bb94f73-061a-4cd7-ae42-3400de7c9c89", "204.25.163.13", "3407a945-1a53-454a-8cf0-939306f39ee7", "No", 3, 14132.685237750932000m, "Purchase", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, (byte)13, new DateTime(2012, 5, 12, 14, 35, 3, 0, DateTimeKind.Unspecified), "4aab7013-0fdf-468a-aa2c-d00254a27263", "181.2.128.110", "a2097548-f2e7-40d6-813d-c88f2bf28f22", "No", 1, 123.0233681841856640m, "Passive", 139.01640604812980032m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, (byte)17, new DateTime(2015, 6, 15, 17, 36, 46, 0, DateTimeKind.Unspecified), "5046fa62-b4ef-4fff-b75a-5486c26dbcdc", "238.12.27.146", "a0977485-466c-42c0-8099-361f0e72632f", "No", 2, 169.210042636789760m, 197.9757498850440192m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, (byte)19, new DateTime(2008, 9, 18, 6, 24, 31, 0, DateTimeKind.Unspecified), "8e8eed08-37c3-43ec-b84d-77e9b51a91d1", "31.131.53.251", "4a8cd4d1-8966-4213-bcc7-71c7ae4c994f", "No", 3, 233.808341679978560m, "Passive", 278.2319265991744864m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, (byte)20, new DateTime(2010, 1, 18, 8, 56, 3, 0, DateTimeKind.Unspecified), "b9bafc42-b742-4a57-a85d-cc009732f108", "204.187.38.156", "741d9faa-121e-4e10-a99d-e5d7201f9b61", "Yes", 3, 170.455054497899840m, 204.546065397479808m, null, null, null },
                    { 5, (byte)18, new DateTime(2019, 3, 1, 2, 37, 15, 0, DateTimeKind.Unspecified), "4f396c5b-483e-4ee4-9d4b-aab9d359616e", "230.229.86.160", "f7c2b86a-9a61-4e72-bc2b-ed3a0fe25348", "Yes", 2, 202.636047775639040m, 239.1105363752540672m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[] { 1, new DateTime(2000, 9, 6, 11, 9, 40, 0, DateTimeKind.Unspecified), "2b8da5ea-fef6-494c-81ab-a4d085134a3e", "193.166.20.102", 4, "f1c0a31c-141d-44ca-b8f1-d2f55ef7463a", "No", "Drive Human Avenue Martinique", null, null, null, 4, "Yesenia.Breitenberg@yahoo.com" });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 8, 24, 11, 58, 16, 0, DateTimeKind.Unspecified), "85aa7d88-3d77-434c-9e99-897edb2193dd", "43.57.24.238", 2, "7238719c-b372-4600-9d25-22c09b2dea2a", "Yes", "backing up lime Refined withdrawal", "Active", null, null, null, 4, "Charley_Franecki6@gmail.com" },
                    { 3, new DateTime(2006, 11, 21, 23, 50, 21, 0, DateTimeKind.Unspecified), "2fda7c04-cff5-4e81-8d44-76da5213886d", "234.106.195.218", 3, "4bfb9873-ec39-4e7a-a904-c6079136e680", "No", "Maine South Georgia and the South Sandwich Islands Borders Iowa", "Active", null, null, null, 2, "Vivien14@gmail.com" },
                    { 4, new DateTime(2001, 12, 3, 15, 57, 28, 0, DateTimeKind.Unspecified), "a283e787-9db4-4d89-b160-664093c4e3b7", "127.144.145.198", 3, "df11d9cd-bcae-47a6-bc7d-7af242c79bc5", "No", "Orchestrator Handcrafted Concrete Pizza Maine syndicate", "Passive", null, null, null, 3, "Kayla93@yahoo.com" },
                    { 5, new DateTime(2003, 1, 2, 20, 47, 48, 0, DateTimeKind.Unspecified), "d43d9d1e-b824-4056-84d8-050820d03380", "250.176.162.9", 4, "31dc6656-2e8e-499c-90cb-12debfc44e20", "No", "Money Market Account Views Investor Sri Lanka Rupee", "Passive", null, null, null, 1, "Newton17@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "Status", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2015, 3, 7, 15, 36, 44, 0, DateTimeKind.Unspecified), new DateTime(2000, 6, 19, 5, 40, 12, 0, DateTimeKind.Unspecified), "12439c15-06b9-4029-9f2b-69fd623d1916", "153.20.38.27", "CNY", "Rustic Soft Sausages Planner", new DateTime(2015, 3, 7, 12, 36, 44, 0, DateTimeKind.Unspecified), "bypassing viral", (byte)15, "45c875dc-395a-4c81-af3a-49ae55715844", "Yes", 154.185789532028752m, "FullyPaid", 181.395046508269120m, "A147", "Active", "Everette Runolfsson", null, null, null },
                    { 2, 3, new DateTime(2014, 9, 2, 18, 23, 41, 0, DateTimeKind.Unspecified), new DateTime(2016, 8, 15, 6, 11, 44, 0, DateTimeKind.Unspecified), "a39cd7ec-a58b-44c3-900e-1a2ac2e70354", "43.198.93.132", "TRY", "Handmade Granite Sausages Investment Account", new DateTime(2014, 9, 2, 15, 23, 41, 0, DateTimeKind.Unspecified), "Tasty Rubber Soap deposit", (byte)11, "44f743d5-4e6c-4ab9-a627-9d5dd394e5b1", "No", 275.1905955557751328m, "PartialPaid", 309.202916354803520m, "D138", "Passive", "Oswald Bahringer", null, null, null },
                    { 3, 5, new DateTime(2009, 5, 27, 15, 19, 36, 0, DateTimeKind.Unspecified), new DateTime(2010, 4, 18, 19, 39, 51, 0, DateTimeKind.Unspecified), "c53c2986-4fad-4434-b2f7-c9565eab7328", "105.9.36.205", "EUR", "visionary Tunnel", new DateTime(2009, 5, 27, 12, 19, 36, 0, DateTimeKind.Unspecified), "incentivize Poland", (byte)15, "07eb9efb-05a5-4283-93d8-19875f7c0a51", "Yes", 293.453515603010208m, "Pending", 345.239430121188480m, "B161", "Passive", "Torrance Luettgen", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 4, 2, new DateTime(2019, 3, 27, 12, 26, 4, 0, DateTimeKind.Unspecified), new DateTime(2006, 11, 27, 16, 44, 47, 0, DateTimeKind.Unspecified), "592905a3-b458-42c6-83ea-1c4c7ba9f9c0", "13.11.209.81", "AED", "Handmade Fresh Hat microchip", new DateTime(2019, 3, 27, 9, 26, 4, 0, DateTimeKind.Unspecified), "interactive transitional", (byte)12, "510464e5-f736-4672-8165-1881f54a8129", "No", 334.8592265635550208m, "FullyPaid", 380.521848367676160m, "B40", "Estell Ankunding", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "Status", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, 5, new DateTime(2021, 1, 5, 16, 25, 28, 0, DateTimeKind.Unspecified), new DateTime(2002, 12, 20, 11, 8, 49, 0, DateTimeKind.Unspecified), "f570242f-7dca-4f83-a1c3-c9734aafaf7f", "106.145.190.82", "USD", "Argentine Peso best-of-breed", new DateTime(2021, 1, 5, 13, 25, 28, 0, DateTimeKind.Unspecified), "system Communications", (byte)15, "ffa8be87-5c25-4779-a21e-a3b62009114f", "Yes", 204.44367886929104m, "Pending", 240.52197514034240m, "C80", "Passive", "Arturo Jaskolski", null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "876 Runolfsdottir Land, East Nelsonbury, Serbia", (byte)45, new DateTime(1979, 12, 10, 12, 21, 14, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 18, 15, 29, 23, 0, DateTimeKind.Unspecified), "29fb7efc-6975-4a6a-a068-75fd66c57a2b", "8.113.34.169", "Marques", "No", "Cummings", "muhammad.name", "09915286962", new DateTime(2023, 8, 1, 15, 59, 47, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "055 Batz Route, Spencerstad, Norfolk Island", (byte)41, new DateTime(1983, 12, 4, 21, 17, 8, 0, DateTimeKind.Unspecified), new DateTime(2006, 4, 18, 10, 27, 12, 0, DateTimeKind.Unspecified), "08bb611b-f8fa-40c7-8b79-c117adf726d6", "62.42.108.168", "Trystan", "Male", "No", "Doyle", "mercedes.biz", "25582161580", new DateTime(2023, 10, 6, 14, 24, 43, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "079 Xzavier Manors, Lake Jamarcus, Bosnia and Herzegovina", (byte)57, new DateTime(1967, 12, 13, 16, 44, 48, 0, DateTimeKind.Unspecified), new DateTime(2005, 8, 27, 12, 14, 9, 0, DateTimeKind.Unspecified), "b45e6952-3837-404f-93d1-be9362890cdc", "146.188.9.167", "Cali", "Male", "No", "Wiegand", "jesse.biz", "Active", "97729284503", new DateTime(2024, 5, 21, 1, 29, 23, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "28404 Deontae Parkway, South Waylonmouth, Jordan", (byte)71, new DateTime(1954, 1, 1, 19, 45, 40, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 24, 9, 13, 22, 0, DateTimeKind.Unspecified), "97acf6e3-6941-4dbe-860c-9908c539c280", "118.211.101.65", "Amely", "No", "Stoltenberg", "carlee.biz", "47080792891", new DateTime(2024, 6, 14, 4, 33, 8, 0, DateTimeKind.Unspecified), null, null },
                    { 5, "10294 Bo Gardens, Elimouth, Peru", (byte)36, new DateTime(1989, 5, 17, 17, 40, 20, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 21, 18, 45, 39, 0, DateTimeKind.Unspecified), "217acd0c-d4d9-4e27-8768-3b309734e07b", "214.71.70.93", "Bret", "No", "Tromp", "hilario.biz", "08387800694", new DateTime(2022, 2, 23, 6, 23, 3, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 1, 5, 1, (short)84, new DateTime(2008, 8, 4, 6, 33, 23, 0, DateTimeKind.Unspecified), "e6cc7177-eb20-4a71-9694-bbd5ff7191a1", "83.79.255.38", 13661m, new DateTime(2008, 2, 7, 16, 19, 30, 0, DateTimeKind.Unspecified), "264f8117-f766-49a5-ad87-6466c1fcdfbe", "Busy", "No", 95043, "48 nz 2680", "Accord", 3, new DateTime(2008, 2, 6, 16, 19, 30, 0, DateTimeKind.Unspecified), "Passive", 13661m, 1, null, null, null, "Sedan" },
                    { 2, 5, 12, (short)87, new DateTime(2002, 1, 18, 19, 15, 34, 0, DateTimeKind.Unspecified), "c88088cc-6615-4155-927b-39eff2ea4756", "123.61.254.25", 11112m, new DateTime(2020, 12, 26, 9, 50, 6, 0, DateTimeKind.Unspecified), "f3abb81f-b28d-408e-88ef-f5b838b10463", "Busy", "No", 162736, "35 zg 4948", "Altima", 1, new DateTime(2020, 12, 21, 9, 50, 6, 0, DateTimeKind.Unspecified), "Active", 55560m, 5, null, null, null, "Minibus" },
                    { 3, 4, 6, (short)62, new DateTime(2014, 2, 26, 12, 51, 36, 0, DateTimeKind.Unspecified), "d0a8a4f9-2683-43e6-91bf-fda8421a8454", "22.49.102.207", 7341m, new DateTime(2014, 8, 11, 11, 47, 14, 0, DateTimeKind.Unspecified), "ead72648-9610-4df8-bd7a-04aef22afd67", "Busy", "Yes", 597771, "26 bt 4229", "XTS", 3, new DateTime(2014, 8, 8, 11, 47, 14, 0, DateTimeKind.Unspecified), "Passive", 22023m, 3, null, null, null, "None" }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 4, 4, 11, (short)20, new DateTime(2000, 2, 10, 15, 33, 39, 0, DateTimeKind.Unspecified), "301b1453-a81e-4d0c-9ef9-a3eb85096792", "214.32.174.59", 18364m, new DateTime(2003, 11, 20, 8, 29, 19, 0, DateTimeKind.Unspecified), "fef29759-cfa8-4ea2-93f3-4f6b9b62be2c", "Busy", "No", 197996, "65 aw 9210", "Model 3", 5, new DateTime(2003, 11, 16, 8, 29, 19, 0, DateTimeKind.Unspecified), 73456m, 4, null, null, null, "Yacht" },
                    { 5, 5, 15, (short)31, new DateTime(2018, 6, 19, 10, 9, 26, 0, DateTimeKind.Unspecified), "196ffa75-79c8-437c-a5d0-d9717fe4cfa2", "35.158.167.81", 10535m, new DateTime(2010, 6, 7, 11, 50, 43, 0, DateTimeKind.Unspecified), "255cd897-a7c6-4377-aa8a-5ace26330972", "Busy", "No", 82020, "1 ny 2451", "PT Cruiser", 5, new DateTime(2010, 6, 3, 11, 50, 43, 0, DateTimeKind.Unspecified), 42140m, 4, null, null, null, "Yacht" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 1, 3, 14, (short)77, new DateTime(2009, 5, 21, 21, 13, 26, 0, DateTimeKind.Unspecified), "9d3f3dce-3ff8-4147-9f99-c722bb0a3049", "122.13.3.56", "1bd66c1e-e329-4ed2-ba18-e0b528569ade", "Busy", "Yes", 306430, "67 qg 1337", 13900468m, "Grand Caravan", new DateTime(2019, 7, 2, 16, 34, 36, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Jeep" },
                    { 2, 2, 6, (short)35, new DateTime(2017, 6, 23, 22, 33, 5, 0, DateTimeKind.Unspecified), "c8cabdb4-a863-4b70-8478-75130f5c8265", "135.166.149.217", "5015b653-6514-4fbb-9ff2-15e50b82671c", "Busy", "Yes", 681447, "17 xz 8711", 21090236m, "Colorado", new DateTime(2013, 8, 24, 5, 52, 26, 0, DateTimeKind.Unspecified), "Active", null, null, null, "Boat" },
                    { 3, 2, 4, (short)86, new DateTime(2001, 9, 10, 7, 47, 29, 0, DateTimeKind.Unspecified), "7f41e00c-750f-468e-8671-8b911452b2e9", "85.48.157.147", "21f319f6-fc96-4784-b005-a1d1b609011a", "Busy", "No", 877274, "77 lm 7562", 14016766m, "Model T", new DateTime(2002, 1, 15, 6, 20, 48, 0, DateTimeKind.Unspecified), "Active", null, null, null, "Sedan" },
                    { 4, 2, 7, (short)63, new DateTime(2000, 6, 23, 16, 37, 49, 0, DateTimeKind.Unspecified), "9848a3c2-cff2-40c4-8e80-4f3fd41ddb9f", "255.204.90.233", "954a3f0e-f1c8-44ca-bb50-ac1b5534d227", "Busy", "Yes", 606395, "46 te 6490", 14044364m, "Beetle", new DateTime(2020, 10, 27, 4, 42, 48, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Bus" },
                    { 5, 5, 13, (short)60, new DateTime(2014, 7, 14, 4, 55, 48, 0, DateTimeKind.Unspecified), "1785d0d5-1739-4de3-b6eb-4b638168c47a", "21.160.8.137", "dad6a68f-2cb9-47dd-9ece-27de6b342325", "Busy", "Yes", 608793, "47 pc 5888", 10641282m, "Beetle", new DateTime(2021, 6, 9, 20, 38, 11, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Boat" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, 2, 1, new DateTime(2006, 10, 6, 15, 47, 25, 0, DateTimeKind.Unspecified), "f8a3fdee-c3b7-47b5-89cc-9bfdd9a7f7a8", "207.83.173.17", 0.0606998918836370m, "58f135c2-e3cd-4c84-a3ae-f6a60a834900", "No", 3, 2188.4408157001720205238804484m, 776.621087974672500m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "Status", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, 3, 3, new DateTime(2001, 2, 5, 2, 42, 12, 0, DateTimeKind.Unspecified), "a1f5c20e-f43c-4ccf-ab65-69120b441349", "176.39.154.103", 0.3572485339975670m, "9b2739b8-c19d-47b6-85e6-44e517bb9e9f", "Yes", 3, "Passive", 302.10337886015049274980932893m, 156.6719511555896600m, null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, 3, 5, new DateTime(2013, 10, 1, 10, 54, 39, 0, DateTimeKind.Unspecified), "d6930a41-62ca-4805-80cb-67b54b66e852", "92.159.157.2", 0.3109006994643660m, "249bd953-89b3-4c7b-99a0-1c7dcef06da5", "No", 3, 1671.3891876160034173311451548m, 808.489761594997800m, null, null, null },
                    { 4, 1, 5, new DateTime(2016, 12, 26, 6, 53, 10, 0, DateTimeKind.Unspecified), "5fc72cd4-bead-4a14-b45c-7e2bee5a517e", "211.180.238.78", 0.1440009325696540m, "1028a9d1-d6c5-462b-876e-7d06d359352e", "No", 1, 404.65976158000054313111273912m, 472.733881351954100m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "Status", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, 2, 4, new DateTime(2001, 6, 17, 8, 29, 54, 0, DateTimeKind.Unspecified), "ee0afb04-329f-4515-bcd8-769917363755", "142.65.210.229", 0.2597510914502160m, "28dde7dc-62c5-4d60-ac8f-8aa43b4aecb0", "No", 3, "Active", 1329.0273377918321012445777557m, 598.4596633383400m, null, null, null });

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
