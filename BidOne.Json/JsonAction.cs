using System.Text.Json;

namespace BidOne.Json
{
    public class JsonAction : IJsonAction
    {
        public void ReadAll()
        {
            throw new NotImplementedException();
        }

        public List<T> Read<T>(string jsonFilePath)
        {
            using StreamReader r = new StreamReader(jsonFilePath);
            string json = r.ReadToEnd();
            return JsonSerializer.Deserialize<List<T>>(json);
        }

        public void Write<T>(List<T> listData, string jsonFilePath)
        {
            using StreamWriter r = new StreamWriter(jsonFilePath);
            var serializedPlayerDetails = JsonSerializer.Serialize<List<T>>(listData);
            r.Write(serializedPlayerDetails);
        }
    }
}