using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarLocator.Api.Infrastructure;
using CarLocator.Api.Vehicles.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Vehicle>> GetAll()
        {
            var vehicles = await _dbContext.Vehicles.ToListAsync();

            return vehicles;
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