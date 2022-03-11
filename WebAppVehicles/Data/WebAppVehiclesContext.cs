using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppVehicles.Model;

namespace WebAppVehicles.Data
{
    public class WebAppVehiclesContext : DbContext
    {
        public WebAppVehiclesContext (DbContextOptions<WebAppVehiclesContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppVehicles.Model.Vehicles> Vehicles { get; set; }
    }
}
