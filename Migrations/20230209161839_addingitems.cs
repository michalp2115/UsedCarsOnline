using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UsedCarsOnline.Migrations
{
    /// <inheritdoc />
    public partial class addingitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "AuctionId", "BodyType", "Color", "Description", "EngineCapacity", "EnginePower", "FuelType", "Gearbox", "ImagePath", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "Sedan", "White", "Description for the Toyota Camry", 2000, 150, "Petrol", "Automatic", "image1.jpg", "Toyota", 50000, "Camry", 10000, "2015" },
                    { 2, "Sedan", "Black", "Description for the Honda Civic", 1800, 140, "Petrol", "Manual", "image2.jpg", "Honda", 40000, "Civic", 15000, "2017" },
                    { 3, "Sedan", "Red", "Description for the Mazda 3", 2000, 160, "Petrol", "Automatic", "image3.jpg", "Mazda", 30000, "3", 20000, "2019" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
