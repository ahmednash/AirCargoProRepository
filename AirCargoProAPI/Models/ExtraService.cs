using System;

namespace AirCargoProAPI.Models
{
    public class ExtraService
    {
        public int ExtraServiceID { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string ReceiptNumber { get; set; }
        public int Amount { get; set; }
        public int CurrencyID { get; set; }
        public string Remarks { get; set; }
        public int CreatedID { get; set; }
        public string CreatedIP { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedID { get; set; }
        public string UpdatedIP { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}