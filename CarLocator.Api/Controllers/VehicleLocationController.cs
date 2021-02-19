using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarLocator.Api.Controllers
{
    public class Location
    {
        public Location(double lat, double lon)
        {
            Lat = lat;
            Lon = lon;
        }

        public double Lat { get;  }
        public double Lon { get;  }
    }

    public class GetVehicleLocationResult
    {
        public GetVehicleLocationResult(Location location)
        {
            Location = location;
        }

        public Location Location { get;  }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class VehicleLocationController : ControllerBase
    {
        [HttpGet]
        public GetVehicleLocationResult Get()
        {
            return new GetVehicleLocationResult(new Location(50.1222, 12.3545));
        }
    }
}
