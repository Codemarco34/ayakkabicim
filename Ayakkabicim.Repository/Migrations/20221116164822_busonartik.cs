using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ayakkabicim.Repository.Migrations
{
    public partial class busonartik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BrandsWebUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    BrandsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ColorBase64Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ColorFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ColorFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCurrencyUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMeasurementUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVatUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsExemtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVatUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductWeightUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWeightUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMixture = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TechnicalWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExplanationWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductColorId = table.Column<int>(type: "int", nullable: false),
                    ProductProjectId = table.Column<int>(type: "int", nullable: false),
                    ProductBrandsId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    WeightId = table.Column<int>(type: "int", nullable: false),
                    ProductVatId = table.Column<int>(type: "int", nullable: false),
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
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductBrands_ProductBrandsId",
                        column: x => x.ProductBrandsId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductColors_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "ProductColors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductCurrencyUnits_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "ProductCurrencyUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductMeasurementUnits_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "ProductMeasurementUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductProjects_ProductProjectId",
                        column: x => x.ProductProjectId,
                        principalTable: "ProductProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductVatUnits_ProductVatId",
                        column: x => x.ProductVatId,
                        principalTable: "ProductVatUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductWeightUnits_WeightId",
                        column: x => x.WeightId,
                        principalTable: "ProductWeightUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "CreateDate", "CreateUserId", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, "Sneakers", null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, "Klasik Ayakkabı", null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, "Günlük Ayakkabı", null, null },
                    { 4, null, null, null, null, null, null, null, null, null, null, null, null, "Erkek Çocuk Ayakkabı", null, null },
                    { 5, null, null, null, null, null, null, null, null, null, null, null, null, "Kız Çocuk Ayakkabı", null, null },
                    { 6, null, null, null, null, null, null, null, null, null, null, null, null, "Topuklu Ayakkabı", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "BrandsCode", "BrandsName", "BrandsWebUrl", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "LogoBase64Content", "LogoFileName", "LogoFilePath", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, "Adidas", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "ProductCurrencyUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "Türk Lirası", null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, null, "Dolar", null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, null, "Euro", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductMeasurementUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "Numara", null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, null, "Uzunluk/cm", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductProjects",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "SuperStep", null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, null, "Ayakkabı Dünyası", null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, null, "Flo", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVatUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "Code", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "IsExemtion", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "18", null, null });

            migrationBuilder.InsertData(
                table: "ProductWeightUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "1,00", null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, null, "1,25", null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, null, "1,50", null, null, null },
                    { 4, null, null, null, null, null, null, null, null, null, null, null, null, null, "1,75", null, null, null },
                    { 5, null, null, null, null, null, null, null, null, null, null, null, null, null, "2,00", null, null, null },
                    { 6, null, null, null, null, null, null, null, null, null, null, null, null, null, "2,25", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActiveDateUpdate", "ActiveDateUpdateUserId", "Barcode", "CategoryId", "Code", "CreateDate", "CreateUserId", "ExpirationDate", "Explanation", "ExplanationWebUrl", "IsActive", "IsActiveDate", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "IsMixture", "LogoBase64Content", "LogoFileName", "LogoFilePath", "Name", "PurchasePrice", "SalePrice", "Stock", "TechnicalWebUrl", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, "AS123", 1, "123AS", new DateTime(2022, 11, 16, 19, 48, 21, 965, DateTimeKind.Local).AddTicks(2625), null, new DateTime(2022, 11, 16, 19, 48, 21, 965, DateTimeKind.Local).AddTicks(2613), "asdasdsad", "adsada", null, null, null, null, null, null, null, null, 1, "asdsadas", "asdasdas", "asdsadas", "Test Ürün1", 10m, 15m, 10, "AS123", new DateTime(2022, 11, 16, 19, 48, 21, 965, DateTimeKind.Local).AddTicks(2628), null });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_CurrencyId",
                table: "ProductFeatures",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_MeasurementId",
                table: "ProductFeatures",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductBrandsId",
                table: "ProductFeatures",
                column: "ProductBrandsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductColorId",
                table: "ProductFeatures",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductProjectId",
                table: "ProductFeatures",
                column: "ProductProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductVatId",
                table: "ProductFeatures",
                column: "ProductVatId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_WeightId",
                table: "ProductFeatures",
                column: "WeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductCurrencyUnits");

            migrationBuilder.DropTable(
                name: "ProductMeasurementUnits");

            migrationBuilder.DropTable(
                name: "ProductProjects");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductVatUnits");

            migrationBuilder.DropTable(
                name: "ProductWeightUnits");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
