using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudDevPOE.Migrations
{
    /// <inheritdoc />
    public partial class Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Venue",
                newName: "VenueId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Event",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Booking",
                newName: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_EventId",
                table: "Booking",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_VenueId",
                table: "Booking",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Event_EventId",
                table: "Booking",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Venue_VenueId",
                table: "Booking",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Event_EventId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Venue_VenueId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_EventId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_VenueId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "Venue",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Event",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Booking",
                newName: "Id");
        }
    }
}
