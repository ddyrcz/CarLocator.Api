using Microsoft.EntityFrameworkCore;
using System;

namespace CarLocator.Api.Vehicles.Entities
{
    [Owned]
    public class Location
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Location MostRecentLocation { get; set; }

        public void UpdateLocation(Location newLocation)
        {
            MostRecentLocation = newLocation;
        }
    }
}