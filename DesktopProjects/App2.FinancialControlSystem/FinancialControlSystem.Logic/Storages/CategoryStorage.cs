using FinancialControlSystem.Logic.Interfaces;
using FinancialControlSystem.Logic.Models;
using System.Transactions;

namespace FinancialControlSystem.Logic.Storages
{
    public class CategoryStorage:AbstractStorage,IAdderer,IRemover
    {
        private Dictionary<int, CategoryModel> _categories;

        public CategoryStorage()
        {
            _categories = [];

            _transactionId = 0;
        }

        public void AddItem()
        {
            Console.WriteLine();
        }

        public void RemoveItem()
        {
            Console.WriteLine();
        }

        public void AddItem(CategoryModel category)
        {
            _categories.Add(_transactionId, category);
            _transactionId++;
        }

    }
}
