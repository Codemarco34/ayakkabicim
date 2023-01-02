using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ayakkabicim.Repository.Migrations
{
    public partial class son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyKind",
                table: "CompanySube");

            migrationBuilder.DropColumn(
                name: "ShortCode",
                table: "CompanySube");

            migrationBuilder.DropColumn(
                name: "CompanyKind",
                table: "CompanyFirma");

            migrationBuilder.DropColumn(
                name: "ShortCode",
                table: "CompanyFirma");

            migrationBuilder.DropColumn(
                name: "CompanyKind",
                table: "CompanyBayi");

            migrationBuilder.DropColumn(
                name: "ShortCode",
                table: "CompanyBayi");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 53, 53, 723, DateTimeKind.Local).AddTicks(7368), new DateTime(2022, 11, 21, 16, 53, 53, 723, DateTimeKind.Local).AddTicks(7357), new DateTime(2022, 11, 21, 16, 53, 53, 723, DateTimeKind.Local).AddTicks(7370) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyKind",
                table: "CompanySube",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortCode",
                table: "CompanySube",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyKind",
                table: "CompanyFirma",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShortCode",
                table: "CompanyFirma",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CompanyKind",
                table: "CompanyBayi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShortCode",
                table: "CompanyBayi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 45, 47, 531, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 11, 18, 15, 45, 47, 531, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 11, 18, 15, 45, 47, 531, DateTimeKind.Local).AddTicks(9411) });
        }
    }
}
