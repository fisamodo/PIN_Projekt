using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PIN_Projekt.Models
{
    public class ParkingContext : DbContext
    {

        public ParkingContext (DbContextOptions<ParkingContext> options)
            : base(options)
        {
        }

        public DbSet<PIN_Projekt.Models.Parking> Parking { get; set; }
    }
}
