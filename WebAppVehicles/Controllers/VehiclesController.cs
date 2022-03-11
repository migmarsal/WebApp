using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVehicles.Data;
using WebAppVehicles.Model;

namespace WebAppVehicles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly WebAppVehiclesContext _context;

        public VehiclesController(WebAppVehiclesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicles>>> GetVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Vehicles>> PostVehicles(Vehicles vehicles)
        {
            _context.Vehicles.Add(vehicles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehicles", new { id = vehicles.IdVehicle }, vehicles);
        }

        private bool VehiclesExists(int id)
        {
            return _context.Vehicles.Any(e => e.IdVehicle == id);
        }
    }
}
