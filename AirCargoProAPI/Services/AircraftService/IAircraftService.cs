using System.Collections.Generic;
using AirCargoProAPI.Models;

namespace AirCargoProAPI.Services.AircraftService
{
    public interface IAircraftService
    {
        List<Aircraft> GetAllAircrafts();
        Aircraft GetAircraftByID(int id);
        List<Aircraft> AddAircraft(Aircraft newAircraft);
    }
}