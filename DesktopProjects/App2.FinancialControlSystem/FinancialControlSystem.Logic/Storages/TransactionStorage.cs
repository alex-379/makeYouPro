using FinancialControlSystem.Logic.Interfaces;
using FinancialControlSystem.Logic.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinancialControlSystem.Logic.Storages
{
    public class TransactionStorage : AbstractStorage, IRemover
    {
        [JsonInclude]
        private Dictionary<int, TransactionModel> _transactions;

        public TransactionStorage()
        {
            _transactions = [];
            _fileLink = Options.CategoryFileLink;
        }

        public void Add(TransactionModel category)
        {
            LoadAll();

            category.Id = _id;
            _transactions.Add(_id, category);
            _id++;

            SaveAll();
        }

        public void RemoveById(int id)
        {
            LoadAll();

            _transactions.Remove(id);

            SaveAll();
        }

        public TransactionModel GetModelById(int id)
        {
            LoadAll();

            return _transactions[id];
        }

        public List<TransactionModel> GetAllModels()
        {
            LoadAll();

            return [.. _transactions.Values];
        }

        public void Update(TransactionModel transaction)
        {
            LoadAll();

            TransactionModel crnt = _transactions[transaction.Id];
            crnt.Name = transaction.Name;
            crnt.FinanceId = transaction.FinanceId;
            crnt.CategoryId = transaction.CategoryId;
            crnt.Summ = transaction.Summ;
            crnt.Date = transaction.Date;
            crnt.IsIncome = transaction.IsIncome;
            crnt.IsApproved = transaction.IsApproved;

            SaveAll();
        }

        private void LoadAll()
        {
            string json;

            if (File.Exists(_fileLink))
            {
                using (StreamReader reader = new(_fileLink))
                {
                    json = reader.ReadToEnd();
                    reader.Close();
                }
                TransactionStorage tmp = JsonSerializer.Deserialize<TransactionStorage>(json);
                _transactions = tmp._transactions;
                _id = tmp._id;
            }
        }
    }
}