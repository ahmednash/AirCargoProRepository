namespace AirCargoProAPI.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCapital { get; set; }
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