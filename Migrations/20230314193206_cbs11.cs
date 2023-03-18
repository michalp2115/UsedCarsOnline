using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UsedCarsOnline.Migrations
{
    /// <inheritdoc />
    public partial class cbs11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "b48ad3da-c2e8-46e2-ad9d-7d0eafc3ae64", new DateTime(2023, 3, 14, 20, 32, 5, 890, DateTimeKind.Local).AddTicks(7831), "7d5a089d-1639-45b3-99df-5ef87f76ce9c" });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "AuctionId", "BodyType", "Color", "Description", "EngineCapacity", "EnginePower", "FuelType", "Gearbox", "ImagePath", "Make", "Mileage", "Model", "Price", "UserId", "Year" },
                values: new object[,]
                {
                    { 10, "Sedan", "White", "Description for the Toyota Camry", "2000", "150", "Petrol", "Automatic", "/images/image1.jpg", "Toyota", "50000", "Camry", "10000", "1", "2015" },
                    { 15, "Sedan", "Black", "Description for the Honda Civic", "2000", "150", "Petrol", "Manual", "/images/image2.jpg", "Honda", "50000", "Civic", "10000", "1", "2017" },
                    { 20, "Sedan", "Red", "Description for the Mazda 3", "2000", "150", "Petrol", "Automatic", "/images/image3.jpg", "Mazda", "50000", "3", "10000", "1", "2019" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "9440036d-8fec-49e1-bcf8-93a856e061db", new DateTime(2023, 3, 14, 20, 30, 56, 280, DateTimeKind.Local).AddTicks(2731), "9589dac5-48c6-410f-853d-fec642eeaeef" });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "AuctionId", "BodyType", "Color", "Description", "EngineCapacity", "EnginePower", "FuelType", "Gearbox", "ImagePath", "Make", "Mileage", "Model", "Price", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Sedan", "White", "Description for the Toyota Camry", "2000", "150", "Petrol", "Automatic", "/images/image1.jpg", "Toyota", "50000", "Camry", "10000", "1", "2015" },
                    { 2, "Sedan", "Black", "Description for the Honda Civic", "2000", "150", "Petrol", "Manual", "/images/image2.jpg", "Honda", "50000", "Civic", "10000", "1", "2017" },
                    { 3, "Sedan", "Red", "Description for the Mazda 3", "2000", "150", "Petrol", "Automatic", "/images/image3.jpg", "Mazda", "50000", "3", "10000", "1", "2019" }
                });
        }
    }
}
