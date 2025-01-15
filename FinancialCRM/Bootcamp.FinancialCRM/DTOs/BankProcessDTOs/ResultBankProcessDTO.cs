using System;

namespace Bootcamp.FinancialCRM.DTOs.BankProcessDTOs
{
    public class ResultBankProcessDTO
    {
        public int BankProcessId { get; set; }
        public string Description { get; set; }
        public DateTime ProcessDate { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
    }
}
