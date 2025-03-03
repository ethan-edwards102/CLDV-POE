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
                    
                );
                
                changed = true;
            }

            if (!context.Event.Any())
            {
                context.Event.AddRange(
                    
                );
                
                changed = true;
            }

            if (!context.Booking.Any())
            {
                context.Booking.AddRange(
                    
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