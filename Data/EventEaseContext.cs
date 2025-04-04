using Microsoft.EntityFrameworkCore;
using EventEase.Models;

namespace EventEase.Data
{
    public class EventEaseContext : DbContext
    {
        public EventEaseContext(DbContextOptions<EventEaseContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Venue> Venue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Venues
            modelBuilder.Entity<Venue>().HasData(
                new Venue
                {
                    VenueId = 1,
                    VenueName = "Grand Convention Center",
                    Location = "123 Main St, New York, NY",
                    Capacity = 5000,
                    ImageUrl = "https://www.congres-deauville.com/wp-content/uploads/2023/01/audi-1497-plenierejbasile-11-1024x683.jpg"
                },
                new Venue
                {
                    VenueId = 2,
                    VenueName = "Sunset Banquet Hall",
                    Location = "45 Sunset Blvd, Los Angeles, CA",
                    Capacity = 300,
                    ImageUrl = "https://www.congres-deauville.com/wp-content/uploads/2023/01/audi-1497-plenierejbasile-11-1024x683.jpg"
                }
            );

            // Seed data for Events
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 1,
                    EventName = "Tech Conference 2025",
                    EventDate = new DateOnly(2025, 5, 15),
                    Description = "An annual gathering of tech enthusiasts, developers, and industry leaders."
                },
                new Event
                {
                    EventId = 2,
                    EventName = "Music Fest",
                    EventDate = new DateOnly(2025, 6, 20),
                    Description = "A weekend-long festival featuring top artists and emerging bands."
                }
            );

            // Seed data for Bookings
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    BookingId = 1,
                    EventId = 1,
                    VenueId = 1,
                    BookingDate = new DateOnly(2025, 3, 1)
                },
                new Booking
                {
                    BookingId = 2,
                    EventId = 2,
                    VenueId = 2,
                    BookingDate = new DateOnly(2025, 4, 10)
                }
            );
        }
    }
}