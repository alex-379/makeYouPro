using FinancialControlSystem.Logic.Enums;

namespace FinancialControlSystem.Logic.Models
{
    public class FinanceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Bank { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        public FinanceType Type { get; set; }
    }

}
