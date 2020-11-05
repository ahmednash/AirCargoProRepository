namespace AirCargoProAPI.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Street { get; set; }
        public int? ZoneID { get; set; }
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public int? IslandID { get; set; }
        public int? AtollID { get; set; }
        public int? StateID { get; set; }
        public int CountryID { get; set; }
        public string PostCode { get; set; }
        public string ZipCode { get; set; }
        [Column(TypeName = "geometry")]
        public IPoint Location { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Remarks { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}