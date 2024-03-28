﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProductCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MFD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StandardCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ProductCategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Bikes" },
                    { 2, "Components" },
                    { 3, "Clothing" },
                    { 4, "Accessories" },
                    { 5, "Mountain Bikes" },
                    { 6, "Road Bikes" },
                    { 7, "Touring Bikes" },
                    { 8, "Handlebars" },
                    { 9, "Bottom Brackets" },
                    { 10, "Brakes" },
                    { 11, "Chains" },
                    { 12, "Cranksets" },
                    { 13, "Derailleurs" },
                    { 14, "Forks" },
                    { 15, "Headsets" },
                    { 16, "Mountain Frames" },
                    { 17, "Pedals" },
                    { 18, "Road Frames" },
                    { 19, "Saddles" },
                    { 20, "Touring Frames" },
                    { 21, "Wheels" },
                    { 22, "Bib-Shorts" },
                    { 23, "Caps" },
                    { 24, "Gloves" },
                    { 25, "Jerseys" },
                    { 26, "Shorts" },
                    { 27, "Socks" },
                    { 28, "Tights" },
                    { 29, "Vests" },
                    { 30, "Bike Racks" },
                    { 31, "Bike Stands" },
                    { 32, "Bottles and Cages" },
                    { 33, "Cleaners" },
                    { 34, "Fenders" },
                    { 35, "Helmets" },
                    { 36, "Hydration Packs" },
                    { 37, "Lights" },
                    { 38, "Locks" },
                    { 39, "Panniers" },
                    { 40, "Pumps" },
                    { 41, "Tires and Tubes" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Available", "Color", "ListPrice", "MFD", "Name", "ProductCategoryID", "ProductNumber", "Size", "StandardCost", "Weight" },
                values: new object[,]
                {
                    { 1, false, "Red", 337.22m, null, "LL Road Frame - Red, 44", 18, "FR-R38R-44", 44, 187.1571m, 1052.33m },
                    { 2, false, "Red", 337.22m, null, "LL Road Frame - Red, 48", 18, "FR-R38R-48", 48, 187.1571m, 1070.47m },
                    { 3, false, "Red", 337.22m, null, "LL Road Frame - Red, 52", 18, "FR-R38R-52", 52, 187.1571m, 1088.62m },
                    { 4, false, "Red", 337.22m, null, "LL Road Frame - Red, 58", 18, "FR-R38R-58", 58, 187.1571m, 1115.83m },
                    { 5, false, "Red", 337.22m, null, "LL Road Frame - Red, 60", 18, "FR-R38R-60", 60, 187.1571m, 1124.9m },
                    { 6, false, "Red", 337.22m, null, "LL Road Frame - Red, 62", 18, "FR-R38R-62", 62, 187.1571m, 1133.98m },
                    { 7, false, "Red", 594.83m, null, "ML Road Frame - Red, 44", 18, "FR-R72R-44", 44, 352.1394m, 1006.97m },
                    { 8, false, "Red", 594.83m, null, "ML Road Frame - Red, 48", 18, "FR-R72R-48", 48, 352.1394m, 1025.11m },
                    { 9, false, "Red", 594.83m, null, "ML Road Frame - Red, 52", 18, "FR-R72R-52", 52, 352.1394m, 1043.26m },
                    { 10, false, "Red", 594.83m, null, "ML Road Frame - Red, 58", 18, "FR-R72R-58", 58, 352.1394m, 1070.47m },
                    { 11, false, "Red", 594.83m, null, "ML Road Frame - Red, 60", 18, "FR-R72R-60", 60, 352.1394m, 1079.54m },
                    { 12, false, "Silver", 1364.5m, null, "HL Mountain Frame - Silver, 44", 16, "FR-M94S-44", 44, 706.811m, 1251.91m },
                    { 13, false, "Silver", 1364.5m, null, "HL Mountain Frame - Silver, 48", 16, "FR-M94S-52", 48, 706.811m, 1270.05m },
                    { 14, false, "Black", 1349.6m, null, "HL Mountain Frame - Black, 44", 16, "FR-M94B-44", 44, 699.0928m, 1251.91m },
                    { 15, false, "Black", 1349.6m, null, "HL Mountain Frame - Black, 48", 16, "FR-M94B-48", 48, 699.0928m, 1270.05m },
                    { 16, false, "Red", 3578.27m, null, "Road-150 Red, 62", 6, "BK-R93R-62", 62, 2171.2942m, 6803.85m },
                    { 17, false, "Red", 3578.27m, null, "Road-150 Red, 44", 6, "BK-R93R-44", 44, 2171.2942m, 6245.93m },
                    { 18, false, "Red", 3578.27m, null, "Road-150 Red, 48", 6, "BK-R93R-48", 48, 2171.2942m, 6409.23m },
                    { 19, false, "Red", 3578.27m, null, "Road-150 Red, 52", 6, "BK-R93R-52", 52, 2171.2942m, 6540.77m },
                    { 20, false, "Red", 3578.27m, null, "Road-150 Red, 56", 6, "BK-R93R-56", 56, 2171.2942m, 6658.7m },
                    { 21, false, "Red", 1457.99m, null, "Road-450 Red, 58", 6, "BK-R68R-58", 58, 884.7083m, 8069.37m },
                    { 22, false, "Red", 1457.99m, null, "Road-450 Red, 60", 6, "BK-R68R-60", 60, 884.7083m, 8119.26m },
                    { 23, false, "Red", 1457.99m, null, "Road-450 Red, 44", 6, "BK-R68R-44", 44, 884.7083m, 7606.7m },
                    { 24, false, "Red", 1457.99m, null, "Road-450 Red, 48", 6, "BK-R68R-48", 48, 884.7083m, 7770m },
                    { 25, false, "Red", 1457.99m, null, "Road-450 Red, 52", 6, "BK-R68R-52", 52, 884.7083m, 7901.54m },
                    { 26, false, "Red", 782.99m, null, "Road-650 Red, 58", 6, "BK-R50R-58", 58, 486.7066m, 8976.55m },
                    { 27, false, "Red", 782.99m, null, "Road-650 Red, 60", 6, "BK-R50R-60", 60, 486.7066m, 9026.44m },
                    { 28, false, "Red", 782.99m, null, "Road-650 Red, 62", 6, "BK-R50R-62", 62, 486.7066m, 9071.8m },
                    { 29, false, "Red", 782.99m, null, "Road-650 Red, 44", 6, "BK-R50R-44", 44, 486.7066m, 8513.88m },
                    { 30, false, "Red", 782.99m, null, "Road-650 Red, 48", 6, "BK-R50R-48", 48, 486.7066m, 8677.18m },
                    { 31, false, "Red", 782.99m, null, "Road-650 Red, 52", 6, "BK-R50R-52", 52, 486.7066m, 8808.72m },
                    { 32, false, "Black", 782.99m, null, "Road-650 Black, 58", 6, "BK-R50B-58", 58, 486.7066m, 8976.55m },
                    { 33, false, "Black", 782.99m, null, "Road-650 Black, 60", 6, "BK-R50B-60", 60, 486.7066m, 9026.44m },
                    { 34, false, "Black", 782.99m, null, "Road-650 Black, 62", 6, "BK-R50B-62", 62, 486.7066m, 9071.8m },
                    { 35, false, "Black", 782.99m, null, "Road-650 Black, 44", 6, "BK-R50B-44", 44, 486.7066m, 8513.88m },
                    { 36, false, "Black", 782.99m, null, "Road-650 Black, 48", 6, "BK-R50B-48", 48, 486.7066m, 8677.18m },
                    { 37, false, "Black", 782.99m, null, "Road-650 Black, 52", 6, "BK-R50B-52", 52, 486.7066m, 8808.72m },
                    { 38, false, "Silver", 3399.99m, null, "Mountain-100 Silver, 38", 5, "BK-M82S-38", 38, 1912.1544m, 9230.56m },
                    { 39, false, "Silver", 3399.99m, null, "Mountain-100 Silver, 42", 5, "BK-M82S-42", 42, 1912.1544m, 9421.06m },
                    { 40, false, "Silver", 3399.99m, null, "Mountain-100 Silver, 44", 5, "BK-M82S-44", 44, 1912.1544m, 9584.36m },
                    { 41, false, "Silver", 3399.99m, null, "Mountain-100 Silver, 48", 5, "BK-M82S-48", 48, 1912.1544m, 9715.9m },
                    { 42, false, "Black", 3374.99m, null, "Mountain-100 Black, 38", 5, "BK-M82B-38", 38, 1898.0944m, 9230.56m },
                    { 43, false, "Black", 3374.99m, null, "Mountain-100 Black, 42", 5, "BK-M82B-42", 42, 1898.0944m, 9421.06m },
                    { 44, false, "Black", 3374.99m, null, "Mountain-100 Black, 44", 5, "BK-M82B-44", 44, 1898.0944m, 9584.36m },
                    { 45, false, "Black", 3374.99m, null, "Mountain-100 Black, 48", 5, "BK-M82B-48", 48, 1898.0944m, 9715.9m },
                    { 46, false, "Black", 1079.99m, null, "Mountain-300 Black, 38", 5, "BK-M47B-38", 38, 598.4354m, 11498.51m },
                    { 47, false, "Black", 1079.99m, null, "Mountain-300 Black, 40", 5, "BK-M47B-40", 40, 598.4354m, 11689.01m },
                    { 48, false, "Black", 1079.99m, null, "Mountain-300 Black, 44", 5, "BK-M47B-44", 44, 598.4354m, 11852.31m },
                    { 49, false, "Black", 1079.99m, null, "Mountain-300 Black, 48", 5, "BK-M47B-48", 48, 598.4354m, 11983.85m },
                    { 50, false, "Red", 2443.35m, null, "Road-250 Red, 44", 6, "BK-R89R-44", 44, 1518.7864m, 6699.52m },
                    { 51, false, "Red", 2443.35m, null, "Road-250 Red, 48", 6, "BK-R89R-48", 48, 1518.7864m, 6862.82m },
                    { 52, false, "Red", 2443.35m, null, "Road-250 Red, 52", 6, "BK-R89R-52", 52, 1518.7864m, 6994.36m },
                    { 53, false, "Black", 348.76m, null, "ML Mountain Frame - Black, 38", 16, "FR-M63B-38", 38, 185.8193m, 1238.3m },
                    { 54, false, "Black", 348.76m, null, "ML Mountain Frame - Black, 40", 16, "FR-M63B-40", 40, 185.8193m, 1256.44m },
                    { 55, false, "Black", 348.76m, null, "ML Mountain Frame - Black, 44", 16, "FR-M63B-44", 44, 185.8193m, 1274.59m },
                    { 56, false, "Black", 348.76m, null, "ML Mountain Frame - Black, 48", 16, "FR-M63B-48", 48, 185.8193m, 1292.73m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
