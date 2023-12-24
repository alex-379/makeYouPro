namespace FinancialControlSystem.Logic.Models
{
    public class TransactionModel
    {
        public int FinanceId { get; set; }

        public string Name { get; set; }

        public decimal  Summ { get; set; }

        public DateTime Date { get; set; }

        public bool IsIncome { get; set; }

        public bool IsApproved { get; set;}
    }
}
