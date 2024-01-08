using FinancialControlSystem.Logic.Enums;

namespace FinancialControlSystem.Logic.Models
{
    public class FinanceModel:AbstractModel
    {

        public string Bank { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        public FinanceType Type { get; set; }
    }

}
