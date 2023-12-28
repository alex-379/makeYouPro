using FinancialControlSystem.Logic.Interfaces;
using FinancialControlSystem.Logic.Models;

namespace FinancialControlSystem.Logic.Storages
{
    public class FinanceStorage:AbstractStorage
    {
        private Dictionary<int, FinanceModel> _finances;

    }
}
