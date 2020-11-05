using System;

namespace AirCargoProAPI.Models
{
    public class Aircraft
    {
        public int AircraftID { get; set; } = 1;
        public string CarrierCode { get; set; } = "UL";
        public string CarrierNumber { get; set; } = "105";
        public string AircraftRegistration { get; set; } = "12345";
        public int AircraftTypeID { get; set; } = 1;
        public string AircraftVersion { get; set; } = "1.0";
        public string RoutingFrom { get; set; } = "MLE";
        public string RoutingTo { get; set; } = "BKK";
        public DateTime ArrivalDate { get; set; } = DateTime.Now;
        public TimeSpan ScheduledArrivalTime { get; set; } = DateTime.Parse("00:00:00").TimeOfDay;
        public TimeSpan ExpectedArrivalTime { get; set; } = TimeSpan.Zero;
        public DateTime DepartureDate { get; set; } = DateTime.Now;
        public TimeSpan ScheduledDepartureTime { get; set; } = TimeSpan.FromHours(1000);
        public TimeSpan ExpectedDepartureTime { get; set; } = TimeSpan.FromHours(10000);
        public TimeSpan TotalDelayTime { get; set; } = TimeSpan.Zero;
        public int NoOfCrewMembers { get; set; } = 100;
        public int PassengersFirstClass { get; set; } = 120;
        public int PassengersBusinessClass { get; set; } = 150;
        public int PassengersEconomyClass { get; set; } = 200;
        public Decimal DryOperatingWeight { get; set; } = 1000.80M;
        public Decimal MaximumTakeOffWeight { get; set; } = 5000.50M;
        public Decimal CargoIn { get; set; } = 1000.37M;
        public Decimal CargoOut { get; set; } = 1000.33M;
        public int CreatedID { get; set; } = 1;
        public string CreatedIP { get; set; } = "127.0.0.1";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int UpdatedID { get; set; } = 1;
        public string UpdatedIP { get; set; } = "127.0.0.1";
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}