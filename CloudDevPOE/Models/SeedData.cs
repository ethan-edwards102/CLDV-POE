using CloudDevPOE.Data;
using Microsoft.EntityFrameworkCore;

namespace CloudDevPOE.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context =
            new CloudDevPOEContext(serviceProvider.GetRequiredService<DbContextOptions<CloudDevPOEContext>>());
        
        var seeded = !context.Venue.Any() | !context.Event.Any() | !context.Booking.Any();

        if (seeded)
        {
            var events = new List<Event>
            {
                new()
                {
                    EventId = 1,
                    EventName = "Tech Conference 2025",
                    EventDate = new DateOnly(2025, 5, 15),
                    Description = "An annual gathering of tech enthusiasts, developers, and industry leaders.",
                    Bookings = new List<Booking>() // Initialize Bookings list
                },
                    
                new()
                {
                    EventId = 2,
                    EventName = "Music Fest",
                    EventDate = new DateOnly(2025, 6, 20),
                    Description = "A weekend-long festival featuring top artists and emerging bands.",
                    Bookings = new List<Booking>()
                }
            };

            var venues = new List<Venue>
            {
                new()
                {
                    VenueId = 1,
                    VenueName = "Grand Convention Center",
                    Location = "123 Main St, New York, NY",
                    Capacity = 5000,
                    ImageUrl = "https://www.congres-deauville.com/wp-content/uploads/2023/01/audi-1497-plenierejbasile-11-1024x683.jpg",
                    Bookings = new List<Booking>() // Initialize Bookings list
                },
                
                new()
                {
                    VenueId = 2,
                    VenueName = "Sunset Banquet Hall",
                    Location = "45 Sunset Blvd, Los Angeles, CA",
                    Capacity = 300,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGp5W-ymP13wMK6Ub_EV1w7OHKaneR7N3Meg&s",
                    Bookings = new List<Booking>()
                }
            };
                
            var bookings = new List<Booking>
            {
                new()
                {
                    BookingId = 1,
                    EventId = 1, // Tech Conference 2025
                    VenueId = 1, // Grand Convention Center
                    BookingDate = new DateOnly(2025, 3, 1)
                },
                
                new()
                {
                    BookingId = 2,
                    EventId = 2, // Music Fest
                    VenueId = 2, // Sunset Banquet Hall
                    BookingDate = new DateOnly(2025, 4, 10)
                }
            };
                
            foreach (var booking in bookings)
            {
                var eventObj = events.First(e => e.EventId == booking.EventId);
                eventObj.Bookings.Add(booking);

                var venueObj = venues.First(v => v.VenueId == booking.VenueId);
                venueObj.Bookings.Add(booking);
            }
            
            context.Venue.AddRange(venues);
            context.Event.AddRange(events);
            context.Booking.AddRange(bookings);

            context.SaveChanges();
        }
    }
}