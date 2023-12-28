using FinancialControlSystem.Logic.Models;
using FinancialControlSystem.Logic.Interfaces;

namespace FinancialControlSystem.Logic.Storages
{
    public abstract class AbstractStorage
    {
        private Dictionary<int, CategoryModel> _categories;
        private Dictionary<int, TransactionModel> _transactions;
        private Dictionary<int, FinanceModel> _finances;

        protected int _transactionId;

        public AbstractStorage()
        {
            _categories = [];
            _transactions = [];
            _finances = [];

            _transactionId = 0;
        }

        //public void AddItem(CategoryModel category)
        //{
        //    _categories.Add(_transactionId, category);
        //    _transactionId++;
        //}

        //public void AddCategory(CategoryModel category)
        //{
        //    _categories.Add(_transactionId, category);
        //    _transactionId++;
        //}

        public void RemoveCategoryById(int id)
        {
            _categories.Remove(id);
        }

        public CategoryModel GetCategoryById(int id)
        {
            return _categories[id];
        }

        public List<CategoryModel> GetAllCategories()
        {
            return [.. _categories.Values];
        }
    }
}
