using System;
using System.Threading.Tasks;
using CarLocator.Api.Infrastructure;
using CarLocator.Api.Vehicles.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarLocator.Api.Vehicles.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly VehicleLocatorDbContext _dbContext;

        public VehiclesController(VehicleLocatorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<Vehicle> Get(Guid id)
        {
            var vehicle = await _dbContext.Vehicles.FindAsync(id);

            return vehicle;
        }

        [HttpPost("{id}")]
        public async Task UpdateLocation(Guid id, Location newLocation)
        {
            var vehicle = await _dbContext.Vehicles.FindAsync(id);  

            vehicle.UpdateLocation(newLocation);

            await _dbContext.SaveChangesAsync();
        }
    }
}