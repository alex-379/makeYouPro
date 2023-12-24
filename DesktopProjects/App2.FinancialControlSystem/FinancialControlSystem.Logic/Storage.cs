using FinancialControlSystem.Logic.Models;

namespace FinancialControlSystem.Logic
{
    public class Storage
    {
        private Dictionary<int, CategoryModel> _categories;
        private Dictionary<int, TransactionModel> _transactions;
        private Dictionary<int, FinanceModel> _finances;

        private int _transactionId;

        public Storage() 
        {
            _categories = [];
            _transactions = [];
            _finances = [];

            _transactionId = 0;
        }

        public void AddCategory (CategoryModel category)
        {
            _categories.Add(_transactionId, category);
            _transactionId++;
        }

        public void RemoveCategoryById (int id)
        {
            _categories.Remove(id);
        }

        public CategoryModel GetCategoryById (int id)
        {
            return _categories[id];
        }

        public List<CategoryModel> GetAllCategories ()
        {
            return [.. _categories.Values]; 
        }
    }
}
