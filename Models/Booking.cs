using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models;

public class Booking
{
    [Key]
    public int BookingId { get; set; }

    [Required]
    [ForeignKey("Event")]  
    public int EventId { get; set; }
    public Event? Event { get; set; }

    [Required]
    [ForeignKey("Venue")]  
    public int VenueId { get; set; }
    public virtual Venue? Venue { get; set; }

    [DataType(DataType.Date)]
    public DateOnly BookingDate { get; set; }
}