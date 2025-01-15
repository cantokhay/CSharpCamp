using Bootcamp.FinancialCRM.Models;
using System;

namespace Bootcamp.FinancialCRM.DTOs.SpendingDTOs
{
    public class ResultSpendingDTO
    {
        public int SpendingId { get; set; }
        public string SpendingTitle { get; set; }
        public decimal SpendingAmount { get; set; }
        public DateTime SpendingDate { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
