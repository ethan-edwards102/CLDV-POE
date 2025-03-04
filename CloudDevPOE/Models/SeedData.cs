using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CloudDevPOE.Data;
using System;
using System.Linq;


namespace CloudDevPOE.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CloudDevPOEContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<CloudDevPOEContext>>()))
        {
            bool changed = false;

            if (!context.Venue.Any())
            {
                context.Venue.AddRange(
                    new Venue
                    {
                        VenueName = "Grand Convention Center",
                        Location = "123 Main St, New York, NY",
                        Capacity = 5000,
                        ImageUrl = "https://example.com/images/grand_convention.jpg"
                    },
                    new Venue
                    {
                        VenueName = "Sunset Banquet Hall",
                        Location = "45 Sunset Blvd, Los Angeles, CA",
                        Capacity = 300,
                        ImageUrl = "https://example.com/images/sunset_banquet.jpg"
                    },
                    new Venue
                    {
                        VenueName = "Skyline Rooftop",
                        Location = "78 Downtown Ave, Chicago, IL",
                        Capacity = 150,
                        ImageUrl = "https://example.com/images/skyline_rooftop.jpg"
                    },
                    new Venue
                    {
                        VenueName = "Lakeside Pavilion",
                        Location = "Lakeview Park, Seattle, WA",
                        Capacity = 1000,
                        ImageUrl = "https://example.com/images/lakeside_pavilion.jpg"
                    },
                    new Venue
                    {
                        VenueName = "Royal Opera House",
                        Location = "Opera Square, London, UK",
                        Capacity = 2500,
                        ImageUrl = "https://example.com/images/royal_opera.jpg"
                    }
                );
                
                changed = true;
            }

            if (!context.Event.Any())
            {
                context.Event.AddRange(
                    new Event
                    {
                        EventName = "Tech Conference 2025",
                        EventDate = new DateOnly(2025, 5, 15),
                        Description = "An annual gathering of tech enthusiasts, developers, and industry leaders."
                    },
                    new Event
                    {
                        EventName = "Music Fest",
                        EventDate = new DateOnly(2025, 6, 20),
                        Description = "A weekend-long festival featuring top artists and emerging bands."
                    },
                    new Event
                    {
                        EventName = "Business Expo",
                        EventDate = new DateOnly(2025, 7, 10),
                        Description = "An exhibition showcasing innovative startups and business solutions."
                    },
                    new Event
                    {
                        EventName = "Gaming Convention",
                        EventDate = new DateOnly(2025, 8, 5),
                        Description = "A convention for gamers, developers, and industry professionals."
                    },
                    new Event
                    {
                        EventName = "Charity Gala",
                        EventDate = new DateOnly(2025, 9, 25),
                        Description = "A fundraising event to support local charities and humanitarian efforts."
                    }
                );
                
                changed = true;
            }

            if (!context.Booking.Any())
            {
                context.Booking.AddRange(
                    new Booking
                    {
                        EventId = 1, // Tech Conference 2025
                        VenueId = 1, // Grand Convention Center
                        BookingDate = new DateOnly(2025, 3, 1)
                    },
                    new Booking
                    {
                        EventId = 2, // Music Fest
                        VenueId = 3, // Skyline Rooftop
                        BookingDate = new DateOnly(2025, 4, 10)
                    },
                    new Booking
                    {
                        EventId = 3, // Business Expo
                        VenueId = 4, // Lakeside Pavilion
                        BookingDate = new DateOnly(2025, 5, 5)
                    },
                    new Booking
                    {
                        EventId = 4, // Gaming Convention
                        VenueId = 2, // Sunset Banquet Hall
                        BookingDate = new DateOnly(2025, 6, 15)
                    },
                    new Booking
                    {
                        EventId = 5, // Charity Gala
                        VenueId = 5, // Royal Opera House
                        BookingDate = new DateOnly(2025, 7, 20)
                    }
                );
                
                changed = true;
            }

            if (changed)
            {
                context.SaveChanges();
            }
        }
    }
}