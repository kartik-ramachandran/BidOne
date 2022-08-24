using BidOne.Domain;

namespace BidOne.Business
{
    public interface IWrite
    {
        void ToJson(PersonalInformation personalInformation, string filePath);
    }
}