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
        public decimal GSTPercent { get; set; }
        public decimal GreenTaxPercent { get; set; }
        public decimal BPTPercent { get; set; }
        public decimal TGSTPercent { get; set; }
        public string Remarks { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}