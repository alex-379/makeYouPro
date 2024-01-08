using FinancialControlSystem.Logic.Interfaces;
using FinancialControlSystem.Logic.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinancialControlSystem.Logic.Storages
{
    public class FinanceStorage : AbstractStorage, IRemover
    {
        [JsonInclude]
        private Dictionary<int, FinanceModel> _financies;

        public FinanceStorage()
        {
            _financies = [];
            _fileLink = Options.FinanceFileLink;
        }

        public void Add(FinanceModel category)
        {
            LoadAll();

            category.Id = _id;
            _financies.Add(_id, category);
            _id++;

            SaveAll();
        }

        public void RemoveById(int id)
        {
            LoadAll();

            _financies.Remove(id);

            SaveAll();
        }

        public FinanceModel GetModelById(int id)
        {
            LoadAll();

            return _financies[id];
        }

        public List<FinanceModel> GetAllModels()
        {
            LoadAll();

            return [.. _financies.Values];
        }

        public void Update(FinanceModel finance)
        {
            LoadAll();

            FinanceModel crnt = _financies[finance.Id];
            crnt.Name = finance.Name;
            crnt.Bank = finance.Bank;
            crnt.Currency = finance.Currency;
            crnt.Balance = finance.Balance;
            crnt.Type = finance.Type;

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
                FinanceStorage tmp = JsonSerializer.Deserialize<FinanceStorage>(json);
                _financies = tmp._financies;
                _id = tmp._id;
            }
        }
    }
}