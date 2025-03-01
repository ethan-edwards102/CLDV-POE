using System.ComponentModel.DataAnnotations;

namespace CloudDevPOE.Models;

public class Venue
{
    public int Id { get; set; }
    
    [Required]
    public string VenueName { get; set; }
    
    public string Location { get; set; }
    public int Capacity { get; set; }
    public string ImageUrl { get; set; }
}