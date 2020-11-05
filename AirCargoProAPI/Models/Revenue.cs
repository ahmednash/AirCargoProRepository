using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirCargoProAPI.Models
{
    public class Revenue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RevenueID { get; set; } = 1;
        public int RevenueTypeID { get; set; } = 1;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Name { get; set; } = "Boeing 747";
        public string ReceiptNumber { get; set; } = "RN-B747";
        public int Amount { get; set; } = 100;
        public int CurrencyID { get; set; } = 1;
        public string Remarks { get; set; } = "Testing...";
        public int CreatedID { get; set; } = 1;
        public string CreatedIP { get; set; } = "127.0.0.1";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int UpdatedID { get; set; } = 1;
        public string UpdatedIP { get; set; } = "127.0.0.1";
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}