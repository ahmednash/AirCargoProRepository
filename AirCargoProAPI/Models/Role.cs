using System;

namespace AirCargoProAPI.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}