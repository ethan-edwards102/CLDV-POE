using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Venue
{
    [Key]
    public int VenueId { get; set; }

    public string VenueName { get; set; }
    public string Location { get; set; }
    public int Capacity { get; set; }
    public string? ImageUrl { get; set; }
    
    // Navigation
    public List<Booking>? Bookings { get; set; }
}