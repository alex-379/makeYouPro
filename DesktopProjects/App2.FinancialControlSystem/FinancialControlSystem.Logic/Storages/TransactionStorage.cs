using FinancialControlSystem.Logic.Models;

namespace FinancialControlSystem.Logic.Storages
{
    internal class TransactionStorage:AbstractStorage
    {
        private Dictionary<int, TransactionModel> _transactions;
    }
}
