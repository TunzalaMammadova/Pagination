using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToMany_task.Migrations
{
    public partial class CreateTableExpertImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 11, 8, 49, 31, 409, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 11, 8, 49, 31, 409, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 11, 8, 49, 31, 409, DateTimeKind.Local).AddTicks(6790));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 11, 7, 35, 3, 602, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 11, 7, 35, 3, 602, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 11, 7, 35, 3, 602, DateTimeKind.Local).AddTicks(1650));
        }
    }
}
