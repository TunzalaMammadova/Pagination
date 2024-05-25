using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToMany_task.Migrations
{
    public partial class CerateSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 19, 0, 51, 16, 236, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 19, 0, 51, 16, 236, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 19, 0, 51, 16, 236, DateTimeKind.Local).AddTicks(4740));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 11, 9, 0, 37, 678, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 11, 9, 0, 37, 678, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 11, 9, 0, 37, 678, DateTimeKind.Local).AddTicks(4900));
        }
    }
}
