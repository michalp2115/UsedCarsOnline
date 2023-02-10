using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsedCarsOnline.Migrations
{
    /// <inheritdoc />
    public partial class itemsupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/image1.jpg");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/image2.jpg");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/image3.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 1,
                column: "ImagePath",
                value: "image1.jpg");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 2,
                column: "ImagePath",
                value: "image2.jpg");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 3,
                column: "ImagePath",
                value: "image3.jpg");
        }
    }
}
