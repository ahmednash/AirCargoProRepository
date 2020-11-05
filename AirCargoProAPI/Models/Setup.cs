using System;

namespace AirCargoProAPI.Models
{
    public class Setup
    {
        public int SetupID { get; set; }
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public string Owner { get; set; }
        public int CompanyID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Street { get; set; }
        public int? ZoneID { get; set; }
        public int? CityID { get; set; }
        public int IslandID { get; set; }
        public int AtollID { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string PostCode { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public decimal GSTPercent { get; set; }
        public decimal GreenTaxPercent { get; set; }
        public decimal BPTPercent { get; set; }
        public string Remarks { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}