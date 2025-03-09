using System.ComponentModel.DataAnnotations;

namespace CloudDevPOE.Models;

public class Event
{
    [Key]
    public int EventId { get; set; }
    
    [Required]
    public string EventName { get; set; }
    
    public DateOnly EventDate { get; set; }
    public string Description { get; set; }
    
    // Navigation
    public List<Booking> Bookings { get; set; }
}