using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ayakkabicim.Repository.Migrations
{
    public partial class view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubeIdId",
                table: "CompanySube",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaIdId",
                table: "CompanyFirma",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BayiIdId",
                table: "CompanyBayi",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 22, 18, 14, 28, 978, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 11, 22, 18, 14, 28, 978, DateTimeKind.Local).AddTicks(9922), new DateTime(2022, 11, 22, 18, 14, 28, 978, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.CreateIndex(
                name: "IX_CompanySube_SubeIdId",
                table: "CompanySube",
                column: "SubeIdId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyFirma_FirmaIdId",
                table: "CompanyFirma",
                column: "FirmaIdId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBayi_BayiIdId",
                table: "CompanyBayi",
                column: "BayiIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyBayi_CompanyBayi_BayiIdId",
                table: "CompanyBayi",
                column: "BayiIdId",
                principalTable: "CompanyBayi",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyFirma_CompanyFirma_FirmaIdId",
                table: "CompanyFirma",
                column: "FirmaIdId",
                principalTable: "CompanyFirma",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySube_CompanySube_SubeIdId",
                table: "CompanySube",
                column: "SubeIdId",
                principalTable: "CompanySube",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyBayi_CompanyBayi_BayiIdId",
                table: "CompanyBayi");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyFirma_CompanyFirma_FirmaIdId",
                table: "CompanyFirma");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanySube_CompanySube_SubeIdId",
                table: "CompanySube");

            migrationBuilder.DropIndex(
                name: "IX_CompanySube_SubeIdId",
                table: "CompanySube");

            migrationBuilder.DropIndex(
                name: "IX_CompanyFirma_FirmaIdId",
                table: "CompanyFirma");

            migrationBuilder.DropIndex(
                name: "IX_CompanyBayi_BayiIdId",
                table: "CompanyBayi");

            migrationBuilder.DropColumn(
                name: "SubeIdId",
                table: "CompanySube");

            migrationBuilder.DropColumn(
                name: "FirmaIdId",
                table: "CompanyFirma");

            migrationBuilder.DropColumn(
                name: "BayiIdId",
                table: "CompanyBayi");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ExpirationDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 11, 21, 16, 53, 53, 723, DateTimeKind.Local).AddTicks(7368), new DateTime(2022, 11, 21, 16, 53, 53, 723, DateTimeKind.Local).AddTicks(7357), new DateTime(2022, 11, 21, 16, 53, 53, 723, DateTimeKind.Local).AddTicks(7370) });
        }
    }
}
