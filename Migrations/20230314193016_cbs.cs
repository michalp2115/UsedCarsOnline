using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UsedCarsOnline.Migrations
{
    /// <inheritdoc />
    public partial class cbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "458bdcd5-9db3-4c24-be24-b8a11833f58b", new DateTime(2023, 3, 14, 20, 30, 16, 593, DateTimeKind.Local).AddTicks(6780), "User", "abc@gmail.com", false, "Cebula", false, null, "Wojtek", null, null, "XxXpLo123!", null, false, "6bb2a763-ca1f-4918-9990-13261e17be16", false, null });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "AuctionId", "BodyType", "Color", "Description", "EngineCapacity", "EnginePower", "FuelType", "Gearbox", "ImagePath", "Make", "Mileage", "Model", "Price", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Sedan", "White", "Description for the Toyota Camry", "2000", "150", "Petrol", "Automatic", "/images/image1.jpg", "Toyota", "50000", "Camry", "10000", "", "2015" },
                    { 2, "Sedan", "Black", "Description for the Honda Civic", "2000", "150", "Petrol", "Manual", "/images/image2.jpg", "Honda", "50000", "Civic", "10000", "", "2017" },
                    { 3, "Sedan", "Red", "Description for the Mazda 3", "2000", "150", "Petrol", "Automatic", "/images/image3.jpg", "Mazda", "50000", "3", "10000", "", "2019" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

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
        }
    }
}
