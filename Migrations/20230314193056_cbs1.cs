using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsedCarsOnline.Migrations
{
    /// <inheritdoc />
    public partial class cbs1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "9440036d-8fec-49e1-bcf8-93a856e061db", new DateTime(2023, 3, 14, 20, 30, 56, 280, DateTimeKind.Local).AddTicks(2731), "9589dac5-48c6-410f-853d-fec642eeaeef" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 1,
                column: "UserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 2,
                column: "UserId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 3,
                column: "UserId",
                value: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "458bdcd5-9db3-4c24-be24-b8a11833f58b", new DateTime(2023, 3, 14, 20, 30, 16, 593, DateTimeKind.Local).AddTicks(6780), "6bb2a763-ca1f-4918-9990-13261e17be16" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 1,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 2,
                column: "UserId",
                value: "");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "AuctionId",
                keyValue: 3,
                column: "UserId",
                value: "");
        }
    }
}
