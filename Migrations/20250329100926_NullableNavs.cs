using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventEase.Migrations
{
    /// <inheritdoc />
    public partial class NullableNavs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Description", "EventDate", "EventName" },
                values: new object[,]
                {
                    { 1, "An annual gathering of tech enthusiasts, developers, and industry leaders.", new DateOnly(2025, 5, 15), "Tech Conference 2025" },
                    { 2, "A weekend-long festival featuring top artists and emerging bands.", new DateOnly(2025, 6, 20), "Music Fest" }
                });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Capacity", "ImageUrl", "Location", "VenueName" },
                values: new object[,]
                {
                    { 1, 5000, "https://www.congres-deauville.com/wp-content/uploads/2023/01/audi-1497-plenierejbasile-11-1024x683.jpg", "123 Main St, New York, NY", "Grand Convention Center" },
                    { 2, 300, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGp5W-ymP13wMK6Ub_EV1w7OHKaneR7N3Meg&s", "45 Sunset Blvd, Los Angeles, CA", "Sunset Banquet Hall" }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookingDate", "EventId", "VenueId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2025, 3, 1), 1, 1 },
                    { 2, new DateOnly(2025, 4, 10), 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2);
        }
    }
}
