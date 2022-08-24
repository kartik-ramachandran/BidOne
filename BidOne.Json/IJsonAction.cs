namespace BidOne.Json
{
    public interface IJsonAction
    {
        List<T> Read<T>(string jsonFilePath);
        void ReadAll();
        void Write<T>(List<T> listData, string jsonFilePath);
    }
}
