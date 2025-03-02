using System.ComponentModel.DataAnnotations;

namespace CloudDevPOE.Models;

public class Booking
{
    public int Id { get; set; }
    
    [Required]
    public int EventId { get; set; }
    [Required]
    public int VenueId { get; set; }
    
    public DateOnly BookingDate { get; set; }
}