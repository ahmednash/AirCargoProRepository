using System;

namespace AirCargoProAPI.Models
{
    public class Aircraft
    {
        public int AircraftID { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierNumber { get; set; }
        public string AircraftRegistration { get; set; }
        public int AircraftTypeID { get; set; }
        public string AircraftVersion { get; set; }
        public string RoutingFrom { get; set; }
        public string RoutingTo { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan ScheduledArrivalTime { get; set; }
        public TimeSpan ExpectedArrivalTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan ScheduledDepartureTime { get; set; }
        public TimeSpan ExpectedDepartureTime { get; set; }
        public TimeSpan TotalDelayTime { get; set; }
        public int NoOfCrewMembers { get; set; }
        public int PassengersFirstClass { get; set; }
        public int PassengersBusinessClass { get; set; }
        public int PassengersEconomyClass { get; set; }
        public Decimal DryOperatingWeight { get; set; }
        public Decimal MaximumTakeOffWeight { get; set; }
        public Decimal CargoIn { get; set; }
        public Decimal CargoOut { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}