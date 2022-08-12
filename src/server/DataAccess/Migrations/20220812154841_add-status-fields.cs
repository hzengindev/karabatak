using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addstatusfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("6f225c6c-ee73-4bbb-a1ab-29a452cc8c89"));

            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "Companies",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "Branches",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BranchId", "CompanyId", "CreatedOn", "CustomerIdentity", "DropOffDate", "ModifiedOn", "PNR", "PaymentStatus", "PickUpDate", "Reference" },
                values: new object[] { new Guid("bf0042db-c94b-4ccc-bc8d-b44a33541c1e"), new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"), new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"), new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3184), "test-employee", new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3187), new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3185), "test-employee", true, new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3187), "test-employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35c708fd-6853-43a1-b670-152e323a576d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ef223f8-548e-4507-af62-e24a85380a78"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 8, 12, 18, 48, 41, 529, DateTimeKind.Local).AddTicks(3144) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bf0042db-c94b-4ccc-bc8d-b44a33541c1e"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Branches");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6071), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(5956), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BranchId", "CompanyId", "CreatedOn", "CustomerIdentity", "DropOffDate", "ModifiedOn", "PNR", "PaymentStatus", "PickUpDate", "Reference" },
                values: new object[] { new Guid("6f225c6c-ee73-4bbb-a1ab-29a452cc8c89"), new Guid("9ff4ef03-39e1-42d7-9b60-d54d183a5ba7"), new Guid("ebfcc5dc-91e0-49e8-aa44-d1b6404e3f1a"), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6118), "test-employee", new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6120), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6119), "test-employee", true, new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6120), "test-employee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35c708fd-6853-43a1-b670-152e323a576d"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6088), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ef223f8-548e-4507-af62-e24a85380a78"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6085), new DateTime(2022, 8, 10, 1, 18, 37, 205, DateTimeKind.Local).AddTicks(6086) });
        }
    }
}
