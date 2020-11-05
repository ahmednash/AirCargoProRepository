namespace AirCargoProAPI.Models
{
    public class Island
    {
        public int IslandID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCapital { get; set; }
        public int LocationID { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}