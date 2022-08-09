using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    APIKey = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueryCounters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryCounters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryCounters_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryCounters_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropOffDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Role = table.Column<short>(type: "smallint", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "APIKey", "CreatedOn", "ModifiedOn", "Name", "UnitPrice" },
                values: new object[] { new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"), "test", new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(5956), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(5964), "Test Company", 2.5m });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "CompanyId", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"), new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6071), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6072), "Test Branch" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BranchId", "CompanyId", "CreatedOn", "CustomerIdentity", "DropOffDate", "ModifiedOn", "PNR", "PaymentStatus", "PickUpDate", "Reference" },
                values: new object[] { new Guid("6f225c6c-ee73-4bbb-a1ab-29a452cc8c89"), new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"), new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6118), "test-employee", new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6120), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6119), "test-employee", true, new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6120), "test-employee" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BranchId", "CreatedOn", "Email", "Firstname", "Lastname", "ModifiedOn", "PasswordHash", "PasswordSalt", "Role", "Status", "Username" },
                values: new object[] { new Guid("35c708fd-6853-43a1-b670-152e323a576d"), new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6088), "manager@test.com", "Test Manager", "Test Manager", new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6088), new byte[0], new byte[0], (short)1, (short)1, "manager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BranchId", "CreatedOn", "Email", "Firstname", "Lastname", "ModifiedOn", "PasswordHash", "PasswordSalt", "Role", "Status", "Username" },
                values: new object[] { new Guid("7ef223f8-548e-4507-af62-e24a85380a78"), new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6085), "employee@test.com", "Test Employee", "Test Employee", new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6086), new byte[0], new byte[0], (short)0, (short)1, "employee" });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CompanyId",
                table: "Branches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryCounters_BranchId",
                table: "QueryCounters",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryCounters_CompanyId",
                table: "QueryCounters",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BranchId",
                table: "Reservations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CompanyId",
                table: "Reservations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                column: "BranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueryCounters");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
