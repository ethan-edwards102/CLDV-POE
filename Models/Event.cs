using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    [Key]
    public int EventId { get; set; }
    
    public string EventName { get; set; }
    
    [DataType(DataType.Date)]
    public DateOnly EventDate { get; set; }
    
    public string Description { get; set; }
    
    // Navigation
    public List<Booking>? Bookings { get; set; }
}