using System;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using GeoAPI.Geometries;
using Microsoft.EntityFrameworkCore;
using NetToplogySuite.Geometries;

namespace AirCargoProAPI.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "geometry")]
        public IPoint Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distance { get; set; }
        public byte[] Picture { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}