using FinancialControlSystem.Logic.Interfaces;
using FinancialControlSystem.Logic.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinancialControlSystem.Logic.Storages
{
    public class CategoryStorage : AbstractStorage, IRemover
    {
        [JsonInclude]
        private Dictionary<int, CategoryModel> _categories;

        public CategoryStorage()
        {
            _categories = [];
            _fileLink = Options.CategoryFileLink;
        }

        public void Add(CategoryModel category)
        {
            LoadAll();

            category.Id = _id;
            _categories.Add(_id, category);
            _id++;

            SaveAll();
        }

        public void RemoveById(int id)
        {
            LoadAll();

            _categories.Remove(id);

            SaveAll();
        }

        public CategoryModel GetModelById(int id)
        {
            LoadAll();

            return _categories[id];
        }

        public List<CategoryModel> GetAllModels()
        {
            LoadAll();

            return [.. _categories.Values];
        }

        public void Update(CategoryModel category)
        {
            LoadAll();

            CategoryModel crnt = _categories[category.Id];
            crnt.Name = category.Name;

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
                CategoryStorage tmp = JsonSerializer.Deserialize<CategoryStorage>(json);
                _categories = tmp._categories;
                _id = tmp._id;
            }
        }
    }
}