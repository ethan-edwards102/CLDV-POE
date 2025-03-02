using System.ComponentModel.DataAnnotations;

namespace CloudDevPOE.Models;

public class Event
{
    public int Id { get; set; }
    
    [Required]
    public string EventName { get; set; }
    
    public DateOnly EventDate { get; set; }
    public string Description { get; set; }
}