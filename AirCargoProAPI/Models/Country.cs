namespace AirCargoProAPI.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }             //  Capital City
        public int RegionID { get; set; }
        public int ContinentID { get; set; }
        [Column(TypeName = "geometry")]
        public IPoint Location { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}