using System;
using System.Collections.Generic;
using System.Linq;
using AirCargoProAPI.Models;

namespace AirCargoProAPI.Services.AircraftService
{
    public class AircraftService : IAircraftService
    {
        private static List<Aircraft> aircrafts = new List<Aircraft> {
            new Aircraft(),
            new Aircraft {
                AircraftID = 2,
                CarrierCode = "SQ",
                CarrierNumber = "555",
                AircraftRegistration = "67890",
                AircraftTypeID = 1,
                AircraftVersion = "2.0",
                RoutingFrom = "CMB",
                RoutingTo = "LDN",
                ArrivalDate = DateTime.Now,
                ScheduledArrivalTime = TimeSpan.Zero,
                ExpectedArrivalTime = TimeSpan.Zero,
                DepartureDate = DateTime.Now,
                ScheduledDepartureTime = TimeSpan.FromHours(2000),
                ExpectedDepartureTime = TimeSpan.FromHours(60000),
                TotalDelayTime = TimeSpan.Zero,
                NoOfCrewMembers = 200,
                PassengersFirstClass = 220,
                PassengersBusinessClass = 250,
                PassengersEconomyClass = 300,
                DryOperatingWeight = 1300.80M,
                MaximumTakeOffWeight = 5500.50M,
                CargoIn = 1060.97M,
                CargoOut = 1060.95M,
                CreatedID = 2,
                CreatedIP = "127.0.0.2",
                CreatedDate = DateTime.Now,
                UpdatedID = 3,
                UpdatedIP = "127.0.0.3",
                UpdateDate = DateTime.Now
            }
        };

        public List<Aircraft> GetAllAircrafts()
        {
            return aircrafts;
        }

        public Aircraft GetAircraftByID(int id)
        {
            return aircrafts.FirstOrDefault(a => a.AircraftID == id);
        }

        public List<Aircraft> AddAircraft(Aircraft newAircraft)
        {
            aircrafts.Add(newAircraft);
            return aircrafts;
        }
    }
}