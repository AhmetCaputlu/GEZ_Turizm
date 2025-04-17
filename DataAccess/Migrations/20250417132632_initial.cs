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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "81e4597a-f451-4f40-849a-67321f2c3b2b"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 838, DateTimeKind.Local).AddTicks(8682)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "6fe0d1f8-cc6a-4245-a4f8-d8bc2a468579"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d429e193-fb0a-4212-a6e6-ea0b879c7a73"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 830, DateTimeKind.Local).AddTicks(3338)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3b04c4e1-ffed-481f-b37c-b940ce5961a7"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "32525b8a-b8bd-4568-b862-1bd3b7c88b45"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 835, DateTimeKind.Local).AddTicks(9045)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "363424f3-9de5-4b79-8a1d-4fdf16b76fcb"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c02b9de0-aa18-422a-8d31-69ba43844d4c"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 850, DateTimeKind.Local).AddTicks(4288)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "5d3dfced-3e83-4225-ad8d-ff5742950fc4"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "2af9df39-3433-4706-9c69-9369fc4ede64"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 837, DateTimeKind.Local).AddTicks(3216)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "bd4fc2fb-d474-47c2-997c-c35365da04c4"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 864, DateTimeKind.Local).AddTicks(3917)),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "d7096914-76e9-4475-9e68-2e09110bbf78"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 841, DateTimeKind.Local).AddTicks(4243)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8fb198ff-5a48-48cc-9a3d-79788d87025b"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "cac16d0b-72a6-48b2-8b5d-eb77aef1bf28"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 831, DateTimeKind.Local).AddTicks(8831)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "058668eb-b5f0-4595-b362-b789e2f3a873"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "58a3cf7e-c346-4749-814a-bb1fc61d68c7"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 828, DateTimeKind.Local).AddTicks(6866)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ff337525-f9b1-4b98-9fe6-e236196caf4d"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8566329a-4262-45ee-804f-748742a388b3"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 840, DateTimeKind.Local).AddTicks(1414)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ceea44a6-a202-4a39-a381-6fa88f8fd7b1"),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 32, 477, DateTimeKind.Local).AddTicks(140)),
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
                name: "ActivityTicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    WebUserEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    WebUserAccountId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "c8582fc6-8311-4b3e-9f71-532e2a92a147"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 847, DateTimeKind.Local).AddTicks(3872)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "a98d8f6c-3b2c-4a1e-95de-2a81c9e5ea4b"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "74fdf448-ea68-421f-9218-548aa95a0043"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 849, DateTimeKind.Local).AddTicks(2259)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "33405c96-e4c2-438e-b77e-fa262834b97f"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "64271c53-155e-44c4-8ce6-ad62bb75203f"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 851, DateTimeKind.Local).AddTicks(8018)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "72c147a2-f1f5-4fee-a004-448ff868a094"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "8d1ccb47-37ea-4d9c-8c90-c8b454bac6ca"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 860, DateTimeKind.Local).AddTicks(4243)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "ccd6c3fd-3a09-4049-bfcc-b85b58016d45"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3b5fe694-c53e-4670-b2fb-8363197e0a8a"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 861, DateTimeKind.Local).AddTicks(8548)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "511751ac-b7b1-433c-911a-c8dd317792e1"),
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
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3257238f-2a14-442b-959e-a9da8271d45d"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 17, 16, 26, 31, 845, DateTimeKind.Local).AddTicks(9819)),
                    CreatedID = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false, defaultValue: "3a3ec3d8-d016-416b-905d-702393cdf77a"),
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
                    { 1, "NorthAmerica", "TR", "Ut molestiae ad incidunt voluptatibus fuga.", "Turkey", "+90", new DateTime(2017, 4, 19, 2, 55, 6, 0, DateTimeKind.Unspecified), "5ba44a3a-23ae-4cf5-a01f-079282197099", "47.180.117.87", "a2ab280f-018c-44d9-b3b7-f28341b06e9c", "No", "Passive", null, null, null },
                    { 2, "NorthAmerica", "RU", "Odit minus culpa est quod qui.", "Russia", "+7", new DateTime(2005, 2, 7, 15, 27, 40, 0, DateTimeKind.Unspecified), "dfaceef4-6346-40a3-b680-7c6fad1e84db", "190.110.119.55", "f96f8c9d-739b-4f56-be04-5cd7caba49b7", "No", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "Africa", "USA", "Dignissimos commodi aliquid est placeat harum.", "United States of America", "+1", new DateTime(2012, 6, 27, 2, 27, 39, 0, DateTimeKind.Unspecified), "ad71928b-f0fb-4afa-a2d6-e1cf80bb5806", "47.27.165.166", "36fbadce-4929-4f1a-9128-eb354f66c9f1", "No", null, null, null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CountryCode", "CountryDescription", "CountryName", "CountryPhone", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "SouthAmerica", "SA", "Nihil quae explicabo et ad adipisci.", "Kingdom of Saudi Arabia", "+966", new DateTime(2013, 5, 4, 14, 15, 39, 0, DateTimeKind.Unspecified), "2491bcac-ce3b-4d3d-ad8a-a4c932beab7a", "251.127.247.188", "6df44975-f768-4b1d-bba6-74a0fc6466f6", "No", "Passive", null, null, null },
                    { 5, "NorthAmerica", "GER", "Dolorem officiis voluptatem sint est dignissimos.", "Germany", "+49", new DateTime(2009, 2, 3, 14, 50, 46, 0, DateTimeKind.Unspecified), "89b0f472-89eb-4d3f-bdf5-d6b75819bea5", "209.50.171.91", "5174840d-1c6f-45e9-8405-ec3f5681d93a", "No", "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Yes", "95708 Jaida Lakes, East Sylviamouth, Austria", 7596.582791103990000m, "Gibson, Little and Stracke LLC", "Brenden Marvin", "Human Configuration Architect", new DateTime(2015, 8, 1, 19, 30, 8, 0, DateTimeKind.Unspecified), "522f291b-cd4d-4f4e-8c1c-df4a3cac09a5", "196.218.71.157", 40810.286186332570000m, 48406.868977436560000m, "Duane97@hotmail.com", "b8820587-1936-408b-9a13-18ca99653dd9", "No", "02134156202", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanies",
                columns: new[] { "Id", "AcceptTickets", "Address", "Balance", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Credit", "Debit", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "Yes", "2290 Amir Corners, Andersontown, Kiribati", 31673.061953346420000m, "Rau, O'Reilly and Bernier LLC", "Anabel Hoppe", "Product Interactions Coordinator", new DateTime(2015, 9, 5, 20, 30, 48, 0, DateTimeKind.Unspecified), "465b2666-338e-41f5-b368-ece66bfe75d3", "228.208.76.199", 46688.05143174250000m, 78361.113385088920000m, "Yvonne.Gerhold72@yahoo.com", "6e08b735-c743-47aa-9bb7-b49d3066b828", "No", "02168364046", "Passive", null, null, null },
                    { 3, "Yes", "332 Edwina Shoal, North Rosie, Samoa", 64860.893956536480000m, "DuBuque, Cormier and Leannon and Sons", "Eliseo Jaskolski", "International Directives Supervisor", new DateTime(2018, 6, 19, 9, 13, 33, 0, DateTimeKind.Unspecified), "78ff5ad8-5bd2-4e87-89fd-d5f621494f7b", "138.219.128.131", 27596.371776563080000m, 92457.265733099560000m, "Novella_Goldner@gmail.com", "eae2af80-9501-46f7-b6b3-feb985eac26b", "No", "02176806595", "Passive", null, null, null },
                    { 4, "No", "1826 Hahn Plain, South Marcellaburgh, Samoa", 27339.343459854750000m, "Stoltenberg, Parker and Hagenes and Sons", "Brigitte Windler", "Forward Solutions Consultant", new DateTime(2003, 9, 5, 22, 59, 48, 0, DateTimeKind.Unspecified), "9d967eb1-29e0-4f44-a8e1-5a8b8f399ad8", "105.43.235.116", 43265.777391173440000m, 70605.120851028190000m, "Toby60@gmail.com", "3b84fc99-285b-479d-9de3-6ba7932b0aeb", "Yes", "02147003476", "Active", null, null, null },
                    { 5, "Yes", "985 Jacobi Wall, South Mortimer, Bermuda", -4928.0955794841510000m, "Crooks, Medhurst and Witting Inc", "Shyanne Witting", "Central Markets Engineer", new DateTime(2020, 3, 15, 21, 28, 54, 0, DateTimeKind.Unspecified), "bbf1c8e5-54ab-44e5-9a50-bbc900bbba6d", "74.236.55.80", 20111.720646627280000m, 15183.6250671431290000m, "Wayne_Paucek@gmail.com", "880ec792-e175-4691-81e6-d34d8f74f71c", "No", "02169564642", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "354 Luettgen Mews, Port Manuelton, Gambia", "Kirlin, Kshlerin and Corwin Group", "Elbert Turner", "Direct Marketing Architect", new DateTime(2007, 10, 18, 11, 38, 14, 0, DateTimeKind.Unspecified), "726cf753-ba24-4161-acba-f69bad8e0d4a", "255.3.7.179", "Antwon1@gmail.com", "a22043e2-c050-4e3c-8506-79597a6269a4", "No", "02175633488", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "3189 Gleason Bypass, Majorfort, Kazakhstan", "Crooks Group Group", "Barbara Rippin", "National Group Technician", new DateTime(2006, 3, 20, 1, 56, 9, 0, DateTimeKind.Unspecified), "b2210fe6-3a92-4828-bed0-751d820ccb67", "208.77.67.151", "Taryn52@hotmail.com", "7b402976-fd37-4ccc-9758-182e39de267c", "No", "02156790268", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "18394 Alana Mount, New Adalbertohaven, Mongolia", "Swift - Goyette Group", "Fay Harber", "Global Optimization Liaison", new DateTime(2000, 9, 18, 22, 13, 18, 0, DateTimeKind.Unspecified), "2d50d8bb-647c-4c8f-8c98-0c98131dd58d", "114.238.104.21", "Edna_Bartell85@gmail.com", "05da5a97-2a95-4dc5-804d-8a6831184837", "No", "02194225082", null, null, null },
                    { 4, "5078 Glover Mountains, Maxieport, Virgin Islands, British", "Beer - Barrows LLC", "Charlotte Turcotte", "Customer Program Facilitator", new DateTime(2006, 7, 18, 4, 38, 17, 0, DateTimeKind.Unspecified), "3c9442d3-ff56-4723-8afe-59eed0104c4d", "17.82.202.70", "Verner.Marks@yahoo.com", "74b57350-5f64-47ae-971e-23f92c6735ae", "No", "02172857826", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicleSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, "57314 Fritsch Curve, Idellmouth, Iceland", "Christiansen - Hettinger and Sons", "Bell Fritsch", "Internal Group Analyst", new DateTime(2020, 4, 27, 2, 57, 41, 0, DateTimeKind.Unspecified), "d8fe8275-1a2b-4ffa-91c2-da24511d2c6f", "206.40.103.129", "Herminio.Ebert0@gmail.com", "5a7d0e3d-eac9-4f5e-9e84-323af51320bb", "No", "02159467733", "Active", null, null, null });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "Status", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 2, 56, 0, 0), new DateTime(2018, 10, 26, 6, 19, 18, 0, DateTimeKind.Unspecified), "3d57b73a-91cd-4a4f-9e8f-92fc0196784f", "33.209.164.174", "explicabo", "4f2aabaf-8128-4788-a7f6-d1db8afe84c5", "No", "Yes", "No", "Passive", "No", 2, null, null, null },
                    { 2, new TimeSpan(0, 2, 37, 0, 0), new DateTime(2011, 7, 11, 17, 55, 25, 0, DateTimeKind.Unspecified), "001dc8ec-f8e2-4798-acb6-070cddd05f8e", "10.108.37.234", "perferendis", "6520f86b-0db2-4d24-9fa0-97af5d4abb61", "No", "No", "No", "Active", "No", 7, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, new TimeSpan(0, 1, 15, 0, 0), new DateTime(2006, 8, 16, 3, 56, 38, 0, DateTimeKind.Unspecified), "0ae01e4f-e974-488b-939a-5d463c3a2182", "106.42.56.232", "quia", "0c3d6579-74aa-448f-96d1-87efe0f5b356", "No", "Yes", "No", "No", 2, null, null, null },
                    { 4, new TimeSpan(0, 1, 21, 0, 0), new DateTime(2008, 5, 4, 16, 33, 10, 0, DateTimeKind.Unspecified), "19bf7e82-7770-4c58-9dac-55d387be6c0f", "145.252.32.98", "culpa", "3dc81783-1dc1-4304-9f16-ff5f4745b2a5", "Yes", "Yes", "No", "No", 4, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceRegions",
                columns: new[] { "Id", "ArrivalTime", "CreatedDate", "CreatedID", "CreatedIPAddress", "DistrictName", "Guid", "HasAirport", "HasHotelFacility", "IsUpdated", "Status", "TouristPopulation", "TransportVehicle", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new TimeSpan(0, 1, 31, 0, 0), new DateTime(2019, 5, 27, 17, 20, 49, 0, DateTimeKind.Unspecified), "494177f5-a711-4a4c-b329-ca0e6065e211", "113.61.231.87", "tenetur", "7bdf4552-751f-469e-b556-a7cfd20ee59c", "No", "No", "No", "Active", "Yes", 6, null, null, null });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "41882 Fadel Mountains, Port Hilario, Saint Vincent and the Grenadines", "Greenfelder and Sons Group", "Rita Kilback", "Regional Interactions Facilitator", new DateTime(2015, 7, 14, 13, 47, 34, 0, DateTimeKind.Unspecified), "36b83ebe-91fc-41b6-9c23-8188dd2324a1", "139.12.108.182", "Scotty.Haley@gmail.com", "7c97b498-b020-4e90-9040-8137082eb5ce", "No", "02130086167", null, null, null },
                    { 2, "158 Marisa Manors, New Cathyville, Bulgaria", "Wisozk, Shields and Schaefer LLC", "Herbert Mitchell", "Human Communications Representative", new DateTime(2003, 1, 16, 14, 22, 8, 0, DateTimeKind.Unspecified), "9ffd4590-1a51-46ad-923e-68237e27971c", "252.220.26.180", "Marcellus_Brekke60@gmail.com", "c5a97d01-663b-487f-85ba-9ef24c5fa694", "Yes", "02142640631", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubContractWorkerSuppliers",
                columns: new[] { "Id", "Address", "CompanyName", "ContactName", "ContactTitle", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "Guid", "IsUpdated", "PhoneNumber", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "820 Reed Ford, North Jaquan, Guernsey", "Bruen, Rau and Gibson Inc", "Ali White", "District Branding Associate", new DateTime(2013, 11, 27, 20, 24, 6, 0, DateTimeKind.Unspecified), "788a6b89-2136-49b4-9c42-4ce3cbdcf711", "91.39.106.182", "Maybell_Mayer91@hotmail.com", "45d743d7-6a16-4d75-bbfb-e3241b8bde41", "No", "02141205996", "Active", null, null, null },
                    { 4, "969 Treva Trail, Altenwerthtown, Cyprus", "Blanda LLC Inc", "Keven Stiedemann", "Global Division Developer", new DateTime(2002, 8, 20, 16, 13, 4, 0, DateTimeKind.Unspecified), "84387538-5f7c-4609-8b9e-d8a4590dfc35", "215.182.179.194", "Angel.Dooley57@gmail.com", "27f3d4ee-5d54-4ca2-8db2-deec9251b8d8", "No", "02165308557", "Passive", null, null, null },
                    { 5, "3356 Murphy Locks, New Angelburgh, Liechtenstein", "O'Keefe - Maggio and Sons", "Stephanie Klocko", "Legacy Security Executive", new DateTime(2015, 9, 3, 10, 27, 25, 0, DateTimeKind.Unspecified), "10ba55fe-4f0d-4027-8c3b-5f7e99d13698", "4.197.17.106", "Connie98@hotmail.com", "bb823185-fd74-418c-840f-61522af5f00f", "No", "02140545025", "Passive", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityCategory", "ActivityName", "CreatedDate", "CreatedID", "CreatedIPAddress", "Description", "EndDate", "Guid", "IsUpdated", "RegionId", "StartDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, "BBQ_Camping", "quod", new DateTime(2014, 9, 5, 19, 47, 15, 0, DateTimeKind.Unspecified), "789ee129-9c88-44b6-a333-f1d62856a205", "164.59.201.62", "Handmade Plastic Shoes Cotton e-tailers Awesome Metal Hat firmware parsing Intelligent Tactics", new DateTime(2019, 2, 17, 17, 21, 10, 0, DateTimeKind.Unspecified), "4e40c2e8-0b0e-43de-adb8-9f9bfbc83a46", "Yes", 1, new DateTime(2019, 2, 17, 6, 21, 10, 0, DateTimeKind.Unspecified), "Passive", null, null, null },
                    { 2, "AncientCity", "cumque", new DateTime(2017, 10, 20, 14, 31, 6, 0, DateTimeKind.Unspecified), "89c70fbc-32d4-470d-95fc-eb6977625b1b", "126.114.175.136", "Frozen Nebraska National Tanzanian Shilling Granite Tunisian Dinar Rapids payment", new DateTime(2008, 5, 2, 12, 24, 34, 0, DateTimeKind.Unspecified), "fbcac298-ad12-4db8-8165-e63b8b5a2559", "No", 4, new DateTime(2008, 5, 2, 5, 24, 34, 0, DateTimeKind.Unspecified), "Passive", null, null, null },
                    { 3, "WayTrek", "possimus", new DateTime(2006, 11, 5, 16, 31, 24, 0, DateTimeKind.Unspecified), "e040f2d4-a557-4827-9a7a-8b3eabb13d2a", "81.217.242.119", "frame Rwanda Franc cross-platform Metal Intelligent Paradigm brand Home Loan Account", new DateTime(2010, 9, 25, 2, 15, 27, 0, DateTimeKind.Unspecified), "837263ab-228e-46ed-9c04-78ba5e0e9e6c", "Yes", 3, new DateTime(2010, 9, 24, 14, 15, 27, 0, DateTimeKind.Unspecified), "Passive", null, null, null },
                    { 4, "Theater", "sed", new DateTime(2003, 11, 13, 8, 43, 51, 0, DateTimeKind.Unspecified), "e8fc4c18-d561-4bc1-8c8c-7d1668e84c25", "102.239.184.233", "Virginia Generic e-tailers Music, Jewelery & Industrial Savings Account sky blue generate circuit", new DateTime(2016, 10, 15, 4, 37, 34, 0, DateTimeKind.Unspecified), "e8c24d8e-9ddc-432d-8bd0-fe8011ee981b", "No", 1, new DateTime(2016, 10, 14, 19, 37, 34, 0, DateTimeKind.Unspecified), "Passive", null, null, null },
                    { 5, "Canyon", "et", new DateTime(2006, 12, 27, 23, 24, 19, 0, DateTimeKind.Unspecified), "1537857c-fb71-408e-8020-62d2737f963e", "87.193.105.111", "Ramp Proactive extranet invoice Borders Realigned Awesome Wooden Table Barbados", new DateTime(2013, 2, 9, 14, 51, 53, 0, DateTimeKind.Unspecified), "64bc0032-3502-41f5-bd22-713dca4629af", "No", 4, new DateTime(2013, 2, 9, 3, 51, 53, 0, DateTimeKind.Unspecified), "Active", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 1, 0, "9fc61ba3-050b-4cca-ba66-ef9160b8b053", 5, new DateTime(2010, 4, 21, 21, 50, 47, 0, DateTimeKind.Unspecified), "eaf0220d-a33c-4c2a-ab52-757994b5513d", "101.87.159.213", "Myrtle_Walker@gmail.com", false, "ec52acec-a001-4782-b1a6-db7c5b4c0f52", "Yes", false, new DateTimeOffset(new DateTime(2025, 4, 24, 16, 26, 31, 986, DateTimeKind.Unspecified).AddTicks(3984), new TimeSpan(0, 3, 0, 0, 0)), "MYRTLE_WALKER@GMAİL.COM", "ORLANDO", "$2a$11$Tj3rN0S0hUHPfKSlw3tfSeqEu1vS1Vb0LtW7HfXfdF6wbKtpDhoSS", "05840848208", false, null, "Passive", false, null, null, null, "Orlando" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 2, 0, "6166f4c4-2bf4-4176-acaf-025cbe85e015", 4, new DateTime(2003, 9, 25, 22, 17, 11, 0, DateTimeKind.Unspecified), "cdf312f6-e980-4edf-acb7-5d1cf69922a4", "6.202.27.176", "Terrence45@hotmail.com", false, "9421f383-c262-4a52-b3e7-f5873b4af77a", "Yes", false, new DateTimeOffset(new DateTime(2025, 4, 24, 16, 26, 32, 109, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, 3, 0, 0, 0)), "TERRENCE45@HOTMAİL.COM", "QUİNCY", "$2a$11$1j2BV5JamAEidlKQGorgFebe/ypW69wuciS0MCB6.bfnXH7GyOI2u", "05228399274", false, null, false, null, null, null, "Quincy" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[,]
                {
                    { 3, 0, "26715e22-e0af-4d31-ac6e-920fd801a469", 4, new DateTime(2007, 4, 27, 8, 34, 48, 0, DateTimeKind.Unspecified), "68a9878c-cd22-4ac7-921e-2aa7e135eecc", "5.158.217.176", "Althea.Dickinson72@yahoo.com", false, "c3879779-62d6-4723-bfe0-ad93e7b08987", "No", false, new DateTimeOffset(new DateTime(2025, 4, 24, 16, 26, 32, 231, DateTimeKind.Unspecified).AddTicks(5095), new TimeSpan(0, 3, 0, 0, 0)), "ALTHEA.DİCKİNSON72@YAHOO.COM", "JACK", "$2a$11$W.N3ueT1NSR0xYqlxxoD/e0S2EpnM96LB1UaCKiaQyYGFOjBnQqhq", "05791921456", false, null, "Active", false, null, null, null, "Jack" },
                    { 4, 0, "62dc063f-9213-451d-8c89-1fe38880a332", 5, new DateTime(2017, 9, 8, 23, 15, 5, 0, DateTimeKind.Unspecified), "573cd583-1fd6-4878-bbd1-aa340c42629e", "12.1.166.160", "Gussie.Weissnat@yahoo.com", false, "02c9523c-57d5-4b6a-beaf-72edbc371b26", "No", false, new DateTimeOffset(new DateTime(2025, 4, 24, 16, 26, 32, 354, DateTimeKind.Unspecified).AddTicks(3883), new TimeSpan(0, 3, 0, 0, 0)), "GUSSİE.WEİSSNAT@YAHOO.COM", "SCARLETT", "$2a$11$vqASKuTeYG/7S8PotLzDgurDzyFMGKt57D2dbFbIdfKXUY4TQjfdy", "05733996090", false, null, "Passive", false, null, null, null, "Scarlett" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Email", "EmailConfirmed", "Guid", "IsUpdated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "UserName" },
                values: new object[] { 5, 0, "0e094a0f-46cc-4149-9e4d-45acdd7a3cec", 2, new DateTime(2017, 8, 19, 3, 35, 53, 0, DateTimeKind.Unspecified), "6158f234-9f23-4519-9042-633c54a4e497", "15.230.45.67", "Syble_Crooks1@gmail.com", false, "d187f43b-2475-4bc2-b19b-0614ed44ed26", "No", false, new DateTimeOffset(new DateTime(2025, 4, 24, 16, 26, 32, 476, DateTimeKind.Unspecified).AddTicks(1649), new TimeSpan(0, 3, 0, 0, 0)), "SYBLE_CROOKS1@GMAİL.COM", "JESSİKA", "$2a$11$/i5XV5DoLYk2OGiZsQZsFeO6WXVxj1TnzqtCiBG.8nDtJttmw8Ioq", "05571440242", false, null, false, null, null, null, "Jessika" });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Northern Ireland", (byte)37, new DateTime(1988, 1, 11, 7, 40, 52, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 3, 19, 31, 36, 0, DateTimeKind.Unspecified), "4514e170-4ebd-4b2e-b5a6-9438e9fbb433", "243.232.188.80", "B", "Jaeden_Green@gmail.com", new DateTime(2013, 6, 17, 2, 12, 41, 0, DateTimeKind.Unspecified), 5, "Jacques", "JacquesMayer", 1, "fa64abe0-dd77-41df-b611-4ca45bdd4888", new DateTime(2012, 6, 17, 2, 12, 41, 0, DateTimeKind.Unspecified), "No", "Italian", "Mayer", "05540426632", "https://lexi.biz/georgia/quality/dynamic", 1, "03585983355", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "England", (byte)59, new DateTime(1965, 11, 11, 2, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2012, 3, 2, 17, 9, 14, 0, DateTimeKind.Unspecified), "9d35c6f2-9c34-4e4a-807c-fdde0fa1165f", "33.35.136.87", "D", "Declan.Schmidt75@gmail.com", new DateTime(2001, 6, 26, 10, 23, 43, 0, DateTimeKind.Unspecified), 3, "Ericka", "ErickaPrice", 1, "22b4a29e-7b70-4659-9703-702c7a43e9d0", new DateTime(2000, 6, 26, 10, 23, 43, 0, DateTimeKind.Unspecified), "No", "English", "Price", "05992554552", "https://bertrand.net/colorado/ssl/granite", "Passive", 5, "23302816133", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 3, "Wales", (byte)64, new DateTime(1960, 6, 21, 17, 32, 17, 0, DateTimeKind.Unspecified), new DateTime(2006, 10, 3, 2, 24, 53, 0, DateTimeKind.Unspecified), "57b1b286-5bf1-408c-89a6-c7481f1fb532", "45.234.211.78", "B", "Maye42@gmail.com", new DateTime(2020, 4, 26, 6, 32, 41, 0, DateTimeKind.Unspecified), 3, "Edythe", "EdytheSchinner", 2, "8fbfbaba-d892-4339-ba9d-2e2c5af433dd", new DateTime(2019, 4, 26, 6, 32, 41, 0, DateTimeKind.Unspecified), "No", "Spanish", "Schinner", "05413627085", "https://max.org/1080p/haptic", 1, "59166975502", null, null, null });

            migrationBuilder.InsertData(
                table: "ContractEmployees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "DriverLicense", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "Language", "LastName", "PhoneNumber", "PhotoPath", "Status", "SupplierId", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, "Wales", (byte)45, new DateTime(1980, 2, 7, 6, 54, 25, 0, DateTimeKind.Unspecified), new DateTime(2014, 11, 16, 9, 15, 27, 0, DateTimeKind.Unspecified), "884fad6d-b6f5-4bb0-a1f3-c93730f60088", "36.150.119.143", "B", "Sasha_Bergnaum@hotmail.com", new DateTime(2007, 1, 3, 21, 14, 40, 0, DateTimeKind.Unspecified), 3, "Naomie", "NaomieJohns", 2, "6e69c2da-d918-4406-be78-988e240f2a73", new DateTime(2006, 1, 3, 21, 14, 40, 0, DateTimeKind.Unspecified), "No", "French", "Johns", "05453502488", "http://pearlie.org/plastic/asymmetric/tangible", "Active", 2, "81096665658", null, null, null },
                    { 5, "Wales", (byte)45, new DateTime(1980, 3, 20, 17, 13, 7, 0, DateTimeKind.Unspecified), new DateTime(2001, 11, 20, 13, 8, 12, 0, DateTimeKind.Unspecified), "5f80baf6-a958-4a7d-8b76-e904de3ba154", "104.166.81.35", "B", "Lula_Morar14@hotmail.com", new DateTime(2004, 5, 26, 15, 20, 9, 0, DateTimeKind.Unspecified), 4, "Elisabeth", "ElisabethEmmerich", 0, "9761e668-a8ee-4f95-9b2d-8d2e7cd7d8f9", new DateTime(2003, 5, 26, 15, 20, 9, 0, DateTimeKind.Unspecified), "No", "Italian", "Emmerich", "05702684351", "https://margret.name/quantifying/ftp", "Active", 3, "42716919198", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "Scotland", (byte)51, new DateTime(1973, 5, 2, 11, 28, 46, 0, DateTimeKind.Unspecified), 5, 1, new DateTime(2013, 6, 19, 19, 18, 36, 0, DateTimeKind.Unspecified), "4642fc15-11e1-42ab-af6c-15d0fddcac03", "101.146.108.159", "Consulting", 4438, "Franz12@hotmail.com", new DateTime(2028, 2, 20, 17, 57, 29, 0, DateTimeKind.Unspecified), 15, "Gerry", "GerryThiel", "Male", "15692b42-92e2-4aa6-83e6-9c1cd60b64f7", new DateTime(2013, 2, 20, 17, 57, 29, 0, DateTimeKind.Unspecified), "No", "Thiel", "05325060539", "http://zack.org/hub/deposit/neural", "39209293183", null, null, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "ContractCount", "CountryId", "CreatedDate", "CreatedID", "CreatedIPAddress", "CurrentPosition", "DaysWorked", "Email", "EndContract", "Experience", "FirstName", "FullName", "Gender", "Guid", "HireDate", "IsUpdated", "LastName", "PhoneNumber", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, "Wales", (byte)32, new DateTime(1992, 8, 8, 11, 37, 46, 0, DateTimeKind.Unspecified), 7, 1, new DateTime(2009, 9, 9, 21, 46, 39, 0, DateTimeKind.Unspecified), "6a38a55a-8607-4399-9fe7-19dde79087ee", "51.151.2.7", "Marketing", 6407, "Noemie52@yahoo.com", new DateTime(2028, 10, 2, 1, 58, 45, 0, DateTimeKind.Unspecified), 19, "Caleb", "CalebRutherford", "Female", "33a422c1-e660-456c-9606-7af8f4f44f0a", new DateTime(2007, 10, 2, 1, 58, 45, 0, DateTimeKind.Unspecified), "Yes", "Rutherford", "05437071807", "https://prudence.net/fantastic-fresh-car", "Active", "41533871309", null, null, null },
                    { 3, "Wales", (byte)49, new DateTime(1975, 9, 18, 15, 40, 43, 0, DateTimeKind.Unspecified), 5, 3, new DateTime(2011, 1, 2, 2, 12, 40, 0, DateTimeKind.Unspecified), "ac71831a-b0c1-4dda-894d-7fa2cb8acd8e", "136.39.119.107", "Consulting", 4547, "Julius.Stiedemann3@yahoo.com", new DateTime(2027, 11, 4, 3, 22, 32, 0, DateTimeKind.Unspecified), 19, "Jada", "JadaDavis", "Male", "84559cee-cb40-4595-b7fd-150354337ead", new DateTime(2012, 11, 4, 3, 22, 32, 0, DateTimeKind.Unspecified), "Yes", "Davis", "05225034338", "http://brandi.name/object-oriented", "Active", "90968527503", null, null, null },
                    { 4, "England", (byte)65, new DateTime(1960, 3, 9, 5, 10, 16, 0, DateTimeKind.Unspecified), 6, 5, new DateTime(2021, 11, 21, 14, 23, 4, 0, DateTimeKind.Unspecified), "c90696fb-7932-4b0a-95d7-027939df80ff", "160.128.110.80", "Consulting", 5459, "Jackeline97@yahoo.com", new DateTime(2028, 5, 7, 4, 52, 12, 0, DateTimeKind.Unspecified), 14, "Meggie", "MeggieBruen", "Female", "2ebe12e8-614e-4948-a971-0fa668dea79a", new DateTime(2010, 5, 7, 4, 52, 12, 0, DateTimeKind.Unspecified), "Yes", "Bruen", "05956077998", "http://alison.com/automotive--movies/multi-channelled", "Passive", "74542806200", null, null, null },
                    { 5, "Wales", (byte)54, new DateTime(1970, 12, 14, 11, 21, 21, 0, DateTimeKind.Unspecified), 7, 5, new DateTime(2003, 3, 1, 4, 9, 46, 0, DateTimeKind.Unspecified), "3e01c598-6d48-4f5f-9c97-edd124e12925", "104.197.110.96", "Marketing", 6747, "Samara.Schoen@gmail.com", new DateTime(2027, 10, 27, 2, 58, 43, 0, DateTimeKind.Unspecified), 23, "Eldora", "EldoraHermann", "Male", "23caec90-2471-4d20-b715-91d45bc7eff2", new DateTime(2006, 10, 27, 2, 58, 43, 0, DateTimeKind.Unspecified), "No", "Hermann", "05492572316", "https://edwardo.net/circuit/central/copying", "Active", "27981274371", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, new DateTime(2006, 1, 25, 9, 15, 3, 0, DateTimeKind.Unspecified), "8415781c-9daa-4a83-bd86-47dcff21a2cf", "66.187.244.254", "c846fdc5-d0c3-4d5c-8bd3-38b53231e81d", "No", 2, 7688.61419264150000m, "Sale", null, null, null });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "Status", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 2, new DateTime(2015, 6, 1, 14, 47, 34, 0, DateTimeKind.Unspecified), "f21fa599-88a9-4b15-954e-4dac1e7cd493", "249.200.45.22", "2b372b22-2fbd-4ada-ad60-c2b10fa12eb2", "Yes", 1, "Passive", 13990.106166410044000m, "Purchase", null, null, null },
                    { 3, new DateTime(2000, 4, 23, 11, 46, 44, 0, DateTimeKind.Unspecified), "ed9ff8c2-9232-4cfe-b10e-1041747f9f58", "230.207.124.92", "e4cafd17-44b8-4e44-b7da-5f3011bf0568", "No", 1, "Active", 3898.668758746236000m, "Purchase", null, null, null },
                    { 4, new DateTime(2004, 4, 17, 3, 10, 24, 0, DateTimeKind.Unspecified), "9b2676b9-41e0-4a91-95df-1062855bde3c", "165.176.242.61", "4dd468bc-b7d6-49e6-bfe3-517bb4946ccd", "Yes", 1, "Passive", 8720.100764284734000m, "Sale", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PartnerCompanyTransactions",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyId", "TotalCost", "Type", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 5, new DateTime(2001, 2, 2, 22, 13, 48, 0, DateTimeKind.Unspecified), "acc8ea46-1a93-45fe-8069-7ad3e82e4f77", "225.114.235.242", "3224d704-8d0d-4fa0-9ac1-a359311ae1f2", "No", 5, 12039.459857420666000m, "Purchase", null, null, null });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "Status", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, (byte)11, new DateTime(2011, 12, 12, 11, 12, 25, 0, DateTimeKind.Unspecified), "3bb256d5-3c95-4d0a-852c-6b6ab60486a4", "88.0.202.163", "510a2eca-998c-4abe-84da-5347d79cd3c1", "No", 2, 139.969996709981760m, "Passive", 155.3666963480797536m, null, null, null },
                    { 2, (byte)8, new DateTime(2010, 4, 8, 7, 20, 16, 0, DateTimeKind.Unspecified), "fab0163c-f233-4499-84ea-e5d3fd65d6b0", "74.182.14.146", "a3171f3a-5d72-4d6c-a578-ddb765a139b1", "No", 1, 330.933166558937280m, "Passive", 357.4078198836522624m, null, null, null },
                    { 3, (byte)18, new DateTime(2006, 5, 11, 8, 39, 47, 0, DateTimeKind.Unspecified), "0b7a24d2-2b63-416b-9248-e9be197aa589", "57.185.123.223", "addf427f-3e1a-4e4a-b6ed-9f7f052eaa87", "No", 2, 297.146132896583680m, "Passive", 350.6324368179687424m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityPassTickets",
                columns: new[] { "Id", "CommissionRate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsUpdated", "PartnerCompanyTransactionId", "Price", "TotalCostwithCommission", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, (byte)9, new DateTime(2011, 7, 17, 22, 57, 2, 0, DateTimeKind.Unspecified), "07d51307-c83f-404f-83bb-a02d937e77a3", "199.175.226.182", "05bcc263-9a42-4772-ae67-8ef14c1684c3", "No", 5, 158.964389795940800m, 173.271184877575472m, null, null, null },
                    { 5, (byte)18, new DateTime(2018, 9, 11, 9, 33, 49, 0, DateTimeKind.Unspecified), "bcf45486-6d45-4dba-aeb0-bddcd71e6a55", "206.47.179.118", "eb33c851-c020-4368-b39d-8c0dcff36523", "No", 5, 218.669969224690880m, 258.0305636851352384m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrders",
                columns: new[] { "Id", "CreatedDate", "CreatedID", "CreatedIPAddress", "EmployeeId", "Guid", "IsUpdated", "Note", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "WebUserAccountId", "WebUserEmail" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 1, 4, 2, 24, 37, 0, DateTimeKind.Unspecified), "3541bb02-2279-49da-8737-ebef44cfdcc7", "181.126.230.112", 3, "2568ecf1-9197-4582-81de-e54532a477ea", "No", "Handcrafted Plastic Chair Nauru Danish Krone 1080p", "Active", null, null, null, 5, "Lewis.Farrell81@hotmail.com" },
                    { 2, new DateTime(2016, 5, 18, 2, 53, 40, 0, DateTimeKind.Unspecified), "4918d5c2-99d5-4f57-b70b-d689895a3a76", "98.204.143.78", 3, "15f602c4-ddff-403f-ba4f-69bd4f6fdc24", "No", "Sao Tome and Principe Movies & Garden Intelligent Manor", "Active", null, null, null, 2, "Dagmar.Heidenreich@yahoo.com" },
                    { 3, new DateTime(2014, 12, 1, 23, 56, 4, 0, DateTimeKind.Unspecified), "ea6eb9e3-6a7b-4893-b5fd-08dee3c28b87", "51.254.125.6", 4, "eca3bbef-1ed7-4c79-93c0-58e277e0bd35", "No", "1080p Sleek copy Granite", "Active", null, null, null, 2, "Philip53@gmail.com" },
                    { 4, new DateTime(2015, 6, 18, 23, 49, 5, 0, DateTimeKind.Unspecified), "bf09d24a-85db-4a92-aaad-91a15736963d", "97.17.249.115", 4, "1024a01c-7592-40ec-8aab-dea1cfd6c27c", "Yes", "Assurance Tasty Investor navigating", "Active", null, null, null, 3, "Jovani29@yahoo.com" },
                    { 5, new DateTime(2017, 8, 2, 6, 30, 20, 0, DateTimeKind.Unspecified), "4903603a-5eb7-406a-a4d5-c08d9aa452ab", "242.249.21.211", 4, "8a1ce2ae-d84e-4c4d-b7f6-a0aad8e12ca6", "No", "Buckinghamshire content-based invoice Books & Games", "Active", null, null, null, 3, "Garrett.Kohler1@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTickets",
                columns: new[] { "Id", "ActivityId", "ArrivalDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "Currency", "DepartureAdress", "DepartureDate", "DestinationAdress", "DiscountRate", "Guid", "IsUpdated", "NetCost", "PaymentStatus", "Price", "SeatNumber", "Status", "TicketHolderName", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2012, 12, 4, 2, 28, 20, 0, DateTimeKind.Unspecified), new DateTime(2004, 9, 23, 1, 17, 6, 0, DateTimeKind.Unspecified), "56af52f0-555f-4b5f-8b8b-c7f90be3d793", "96.254.255.4", "TRY", "Light payment", new DateTime(2012, 12, 3, 23, 28, 20, 0, DateTimeKind.Unspecified), "Re-contextualized pixel", (byte)17, "6a6926ed-7b53-4ae4-8ca8-e60de7c6bd66", "Yes", 310.422148248626144m, "PartialPaid", 374.00258825135680m, "C89", "Passive", "Rickie Rowe", null, null, null },
                    { 2, 2, new DateTime(2000, 5, 7, 22, 35, 11, 0, DateTimeKind.Unspecified), new DateTime(2005, 4, 7, 7, 22, 39, 0, DateTimeKind.Unspecified), "c23b1401-4571-4fb6-8114-68544ad4e7e2", "104.22.178.146", "EUR", "payment SAS", new DateTime(2000, 5, 7, 19, 35, 11, 0, DateTimeKind.Unspecified), "Plastic Prairie", (byte)15, "2d464c33-ce3b-43c9-876e-e3879207ebf2", "No", 321.308744150873632m, "PartialPaid", 378.010287236321920m, "A172", "Passive", "Francesco Yundt", null, null, null },
                    { 3, 5, new DateTime(2015, 3, 1, 13, 28, 28, 0, DateTimeKind.Unspecified), new DateTime(2006, 9, 20, 14, 20, 40, 0, DateTimeKind.Unspecified), "d8781b48-ccfd-4db4-a50a-091ce4683237", "154.193.205.25", "TRY", "non-volatile Profound", new DateTime(2015, 3, 1, 10, 28, 28, 0, DateTimeKind.Unspecified), "Director Global", (byte)19, "6165a699-4140-41ee-bf73-5466a859af31", "No", 181.2559458302139456m, "PartialPaid", 223.772772629893760m, "B58", "Passive", "Itzel Rath", null, null, null },
                    { 4, 4, new DateTime(2010, 11, 10, 22, 59, 29, 0, DateTimeKind.Unspecified), new DateTime(2013, 3, 3, 14, 37, 22, 0, DateTimeKind.Unspecified), "92a455ca-ab70-408e-82e9-488597a2faf7", "27.112.17.55", "CNY", "channels invoice", new DateTime(2010, 11, 10, 19, 59, 29, 0, DateTimeKind.Unspecified), "leverage Practical Metal Computer", (byte)13, "51418d8a-4771-4093-975b-391c56f1c252", "Yes", 207.2548947726233856m, "Pending", 238.224016980026880m, "A31", "Passive", "Chelsea Herman", null, null, null },
                    { 5, 5, new DateTime(2018, 10, 8, 0, 49, 30, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 4, 17, 45, 54, 0, DateTimeKind.Unspecified), "bd968ab1-b94d-4665-8807-20577e6030fd", "1.155.23.231", "JPY", "Bangladesh Tasty", new DateTime(2018, 10, 7, 21, 49, 30, 0, DateTimeKind.Unspecified), "neural Auto Loan Account", (byte)19, "805caf60-af2f-4e4f-85c1-205fd45c15a9", "No", 271.9420075892274912m, "Pending", 335.730873566947520m, "C170", "Active", "Jaida Emard", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 1, "4866 Fredrick Streets, New Eula, Democratic People's Republic of Korea", (byte)69, new DateTime(1956, 2, 10, 3, 27, 33, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 23, 12, 48, 38, 0, DateTimeKind.Unspecified), "dd0eedbf-3b42-4223-87c4-5f978abbcd3b", "66.186.189.165", "Jade", "Female", "No", "Turcotte", "riley.info", "89056655421", new DateTime(2022, 1, 20, 20, 37, 36, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "Status", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[] { 2, "0472 Shanel Shoals, Chaddfort, Mali", (byte)25, new DateTime(1999, 12, 12, 15, 18, 22, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 14, 8, 35, 49, 0, DateTimeKind.Unspecified), "32bbf0fe-9b8f-4263-994c-87a31a22904f", "39.117.126.32", "Benny", "Male", "Yes", "Wisozk", "brandyn.name", "Passive", "91578846122", new DateTime(2023, 12, 22, 18, 39, 46, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserProfiles",
                columns: new[] { "WebUserAccountId", "Address", "Age", "BirthDate", "CreatedDate", "CreatedID", "CreatedIPAddress", "FirstName", "Gender", "IsUpdated", "LastName", "PhotoPath", "TCN_Passport", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 3, "41181 Yasmin Place, Bayerton, Myanmar", (byte)21, new DateTime(2004, 2, 18, 3, 38, 20, 0, DateTimeKind.Unspecified), new DateTime(2008, 1, 13, 8, 44, 30, 0, DateTimeKind.Unspecified), "e2e26704-5579-41b8-8030-cfda88d2063e", "242.159.167.0", "Alexys", "Male", "No", "Sporer", "frederik.com", "13381191120", new DateTime(2022, 9, 5, 23, 52, 50, 0, DateTimeKind.Unspecified), null, null },
                    { 4, "6373 Reece Heights, West Megane, Iceland", (byte)23, new DateTime(2001, 8, 13, 14, 36, 40, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 2, 14, 22, 11, 0, DateTimeKind.Unspecified), "4444e4f6-474d-4f81-80cf-d13ef210aeca", "94.6.239.105", "Patsy", "Female", "No", "Labadie", "ayana.org", "30544883057", new DateTime(2024, 6, 5, 17, 39, 6, 0, DateTimeKind.Unspecified), null, null },
                    { 5, "882 Edna Fields, Kuhnhaven, Netherlands Antilles", (byte)49, new DateTime(1976, 2, 16, 18, 8, 49, 0, DateTimeKind.Unspecified), new DateTime(2007, 6, 8, 23, 57, 50, 0, DateTimeKind.Unspecified), "72b645d2-99d5-4832-a8dc-bf4daf931e6b", "201.66.64.197", "Chloe", "Male", "Yes", "Heidenreich", "johnson.biz", "84472456655", new DateTime(2022, 6, 10, 13, 14, 11, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 1, 3, 13, (short)38, new DateTime(2002, 7, 12, 17, 23, 12, 0, DateTimeKind.Unspecified), "ae70ab07-3e16-4a00-8617-a5ec93142fe7", "164.139.4.94", 13222m, new DateTime(2020, 10, 16, 12, 14, 50, 0, DateTimeKind.Unspecified), "990078c5-61c7-43ab-94f2-5b642dbc8c71", "Busy", "No", 983909, "67 uq 8191", "Fiesta", 4, new DateTime(2020, 10, 12, 12, 14, 50, 0, DateTimeKind.Unspecified), "Active", 52888m, 4, null, null, null, "Jeep" },
                    { 2, 1, 2, (short)40, new DateTime(2012, 2, 20, 21, 51, 17, 0, DateTimeKind.Unspecified), "3479b8b4-bcee-412a-92ae-3d3295a9b9a7", "190.224.169.166", 20183m, new DateTime(2019, 10, 15, 17, 23, 8, 0, DateTimeKind.Unspecified), "e680ca9c-a150-4dfe-ac53-ae40647f3990", "Available", "No", 898647, "32 lz 3759", "Silverado", 4, new DateTime(2019, 10, 11, 17, 23, 8, 0, DateTimeKind.Unspecified), "Active", 80732m, 4, null, null, null, "Jeep" },
                    { 3, 1, 5, (short)72, new DateTime(2016, 12, 9, 11, 47, 16, 0, DateTimeKind.Unspecified), "fc1ce96d-22a5-425f-9217-ce380c036654", "241.240.234.220", 15475m, new DateTime(2015, 4, 18, 21, 37, 8, 0, DateTimeKind.Unspecified), "b7ffeb95-93b9-400d-ab00-30af2380cafb", "Busy", "No", 67936, "26 ga 2762", "Element", 2, new DateTime(2015, 4, 13, 21, 37, 8, 0, DateTimeKind.Unspecified), "Active", 77375m, 5, null, null, null, "Motorbike" }
                });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 4, 3, 14, (short)94, new DateTime(2014, 10, 18, 22, 44, 28, 0, DateTimeKind.Unspecified), "ff66427d-16e0-4520-a785-389d1e49b566", "170.88.41.22", 19270m, new DateTime(2020, 12, 21, 20, 24, 52, 0, DateTimeKind.Unspecified), "b34b97dd-ae62-4b93-bdb8-a94eeb5966e9", "Available", "Yes", 757554, "57 pf 9599", "Spyder", 1, new DateTime(2020, 12, 16, 20, 24, 52, 0, DateTimeKind.Unspecified), 96350m, 5, null, null, null, "Bus" });

            migrationBuilder.InsertData(
                table: "RentalVehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "DailyRentalFee", "ExpireDate", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "Model", "RentalVehicleSupplierId", "StartDate", "Status", "TotalPrice", "TotalRentalDay", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 5, 1, 8, (short)84, new DateTime(2009, 9, 26, 7, 51, 24, 0, DateTimeKind.Unspecified), "c655e979-2b3d-41fd-b0d4-154ad59b4521", "28.60.218.49", 21932m, new DateTime(2008, 9, 23, 19, 25, 9, 0, DateTimeKind.Unspecified), "515ad794-56f7-48db-aa85-11bb49787f4a", "Busy", "Yes", 622205, "55 hj 7455", "Prius", 4, new DateTime(2008, 9, 22, 19, 25, 9, 0, DateTimeKind.Unspecified), "Active", 21932m, 1, null, null, null, "Minibus" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 1, 5, 7, (short)82, new DateTime(2007, 3, 19, 3, 25, 48, 0, DateTimeKind.Unspecified), "3357308c-6870-424f-ad6f-0ece6f034d69", "109.207.106.109", "f2df94c4-aee1-4eb8-87bf-8bd98a5ad357", "Busy", "Yes", 148342, "47 yr 1495", 17177848m, "CTS", new DateTime(2005, 6, 13, 5, 11, 31, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Jeep" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 2, 2, 12, (short)33, new DateTime(2004, 10, 7, 11, 31, 26, 0, DateTimeKind.Unspecified), "790a286e-456c-46ea-ae54-666023c62e34", "169.106.77.118", "d011a69a-19a2-4154-b4ab-27e09a5f0de4", "Busy", "No", 6414, "12 im 1632", 20208650m, "Altima", new DateTime(2016, 11, 11, 16, 16, 43, 0, DateTimeKind.Unspecified), null, null, null, "Yacht" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "Status", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[] { 3, 4, 7, (short)3, new DateTime(2012, 5, 2, 14, 46, 2, 0, DateTimeKind.Unspecified), "1187d115-a27f-498c-9668-2bed07e44e17", "98.102.64.16", "ea597ce8-89a7-4333-8550-7818a8352424", "Busy", "No", 44403, "80 hx 8415", 20328187m, "Alpine", new DateTime(2009, 5, 13, 22, 28, 23, 0, DateTimeKind.Unspecified), "Passive", null, null, null, "Motorbike" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "ActivityId", "Age", "Capacity", "CreatedDate", "CreatedID", "CreatedIPAddress", "Guid", "IsAvailable", "IsUpdated", "Kilometer", "LicensePlate", "MarketValue", "Model", "PurchaseDate", "UpdatedDate", "UpdatedID", "UpdatedIPAddress", "VehicleType" },
                values: new object[,]
                {
                    { 4, 4, 11, (short)30, new DateTime(2019, 8, 11, 15, 28, 7, 0, DateTimeKind.Unspecified), "8a6511f3-b07e-47de-b5db-b24f845a1fcb", "215.134.192.209", "782fed40-11c3-427b-ac8d-2d89fc819f62", "Available", "No", 781087, "57 qk 3403", 8577622m, "CX-9", new DateTime(2001, 5, 8, 18, 29, 12, 0, DateTimeKind.Unspecified), null, null, null, "Bus" },
                    { 5, 2, 5, (short)47, new DateTime(2015, 1, 20, 20, 25, 21, 0, DateTimeKind.Unspecified), "fe3aac8d-84b8-440f-9877-aae98ba0bf52", "64.11.86.41", "22bc95c1-bf1e-4f84-9071-463b58971bf6", "Busy", "No", 718849, "11 ei 2095", 9194070m, "Expedition", new DateTime(2009, 4, 3, 21, 44, 33, 0, DateTimeKind.Unspecified), null, null, null, "Motorbike" }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "Status", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 1, 5, 3, new DateTime(2017, 9, 18, 19, 26, 24, 0, DateTimeKind.Unspecified), "b9aafebd-7a7b-4845-a369-b76944992e2d", "15.206.248.13", 0.4800361953999940m, "b9753312-051d-416c-aab8-fc4de6676eea", "No", 4, "Active", 1484.2799992075548980331972223m, 713.645827880928700m, null, null, null },
                    { 2, 3, 5, new DateTime(2004, 5, 8, 5, 32, 11, 0, DateTimeKind.Unspecified), "60c48f63-c6d4-4ba6-a998-a7ec5642c6c8", "218.28.41.134", 0.1963128773413240m, "181a89cd-a525-40d1-93a9-2f12e3e48a61", "No", 1, "Passive", 596.91710245460485062252250713m, 742.723238466163800m, null, null, null },
                    { 3, 2, 3, new DateTime(2010, 10, 9, 18, 44, 45, 0, DateTimeKind.Unspecified), "74961e58-28a2-4d8c-9aa1-b00f2b60d5fc", "222.105.169.91", 0.3560518107906130m, "60fff5b2-c142-453e-90ff-8dac2230db5b", "No", 2, "Passive", 726.61555026364047897880471858m, 564.187897752883700m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ActivityTicketOrderDetails",
                columns: new[] { "Id", "ActivityTicketId", "ActivityTicketOrderId", "CreatedDate", "CreatedID", "CreatedIPAddress", "Discount", "Guid", "IsUpdated", "Quantity", "TotalCost", "UnitPrice", "UpdatedDate", "UpdatedID", "UpdatedIPAddress" },
                values: new object[,]
                {
                    { 4, 4, 1, new DateTime(2002, 2, 18, 22, 46, 28, 0, DateTimeKind.Unspecified), "7ddc0d24-04bf-4b83-9340-bae2c0ec2ee6", "103.174.48.213", 0.1411787578237905m, "d637ba0b-5779-47a1-9375-e2687e19c54f", "No", 1, 98.68019800485039830542087729m, 114.9019064256023500m, null, null, null },
                    { 5, 1, 5, new DateTime(2017, 1, 9, 18, 39, 42, 0, DateTimeKind.Unspecified), "7b2d822c-9fb9-42a5-8fd7-387811581f67", "226.73.167.24", 0.341885920412660m, "0d2cd2c5-2484-4062-8287-3b0d60b87464", "No", 4, 1959.9420199250070702203456880m, 744.529740631729700m, null, null, null }
                });

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
