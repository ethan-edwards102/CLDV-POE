using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudDevPOE.Models;

namespace CloudDevPOE.Data
{
    public class CloudDevPOEContext : DbContext
    {
        public CloudDevPOEContext (DbContextOptions<CloudDevPOEContext> options)
            : base(options)
        {
        }

        public DbSet<CloudDevPOE.Models.Venue> Venue { get; set; } = default!;
    }
}
