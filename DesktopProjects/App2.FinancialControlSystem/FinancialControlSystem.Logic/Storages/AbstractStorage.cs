using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinancialControlSystem.Logic.Storages
{
    public abstract class AbstractStorage
    {
        [JsonInclude]
        protected int _id = 0;

        protected string _fileLink;

        protected void SaveAll()
        {
            string json = JsonSerializer.Serialize(this);
            using (StreamWriter writer = new(_fileLink, false))
            {
                writer.Write(json);
                writer.Close();
            }
        }
    }
}