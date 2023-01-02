using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ayakkabicim.Repository.Migrations
{
    public partial class Company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyBayi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    FaxNumber = table.Column<int>(type: "int", nullable: false),
                    WebUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<int>(type: "int", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EInvoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBayi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyFirma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    FaxNumber = table.Column<int>(type: "int", nullable: false),
                    WebUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<int>(type: "int", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EInvoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyFirma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySube",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    FaxNumber = table.Column<int>(type: "int", nullable: false),
                    WebUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<int>(type: "int", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EInvoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySube", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 45, 47, 531, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 11, 18, 15, 45, 47, 531, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 11, 18, 15, 45, 47, 531, DateTimeKind.Local).AddTicks(9411) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyBayi");

            migrationBuilder.DropTable(
                name: "CompanyFirma");

            migrationBuilder.DropTable(
                name: "CompanySube");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 16, 19, 48, 21, 965, DateTimeKind.Local).AddTicks(2625), new DateTime(2022, 11, 16, 19, 48, 21, 965, DateTimeKind.Local).AddTicks(2613), new DateTime(2022, 11, 16, 19, 48, 21, 965, DateTimeKind.Local).AddTicks(2628) });
        }
    }
}
