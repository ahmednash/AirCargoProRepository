using System.Collections.Generic;
using System.Threading.Tasks;
using AirCargoProAPI.Models;

namespace AirCargoProAPI.Services.AircraftService
{
    public interface IAircraftService
    {
        Task<ServiceResponse<List<Aircraft>>> GetAllAircrafts();
        Task<ServiceResponse<Aircraft>> GetAircraftByID(int id);
        Task<ServiceResponse<List<Aircraft>>> AddAircraft(Aircraft newAircraft);
    }
}