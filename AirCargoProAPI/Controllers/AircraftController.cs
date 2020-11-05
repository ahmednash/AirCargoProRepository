using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AirCargoProAPI.Models;
using AirCargoProAPI.Services.AircraftService;

namespace AirCargoProAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AircraftController : ControllerBase
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

        private readonly IAircraftService _aircraftService;
        private readonly ILogger<AircraftController> _logger;
        ILogger<AircraftController> logger = null;

        public AircraftController(IAircraftService aircraftService)
        {
            _aircraftService = aircraftService;
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_aircraftService.GetAllAircrafts());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_aircraftService.GetAircraftByID(id));
        }

        [HttpPost]
        public IActionResult AddAircraft(Aircraft newAircraft)
        {
            return Ok(_aircraftService.AddAircraft(newAircraft));
        }
    }
}