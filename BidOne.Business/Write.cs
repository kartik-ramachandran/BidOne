using BidOne.Domain;
using BidOne.Json;

namespace BidOne.Business
{
    public class Write : IWrite
    {
        private readonly IJsonAction _jsonAction;

        public Write(IJsonAction jsonAction)
        {
            _jsonAction = jsonAction;
        }

        public void ToJson(PersonalInformation personalInformation, string filePath)
        {
            var tempList = new List<PersonalInformation>();
            tempList.Add(personalInformation);

            try
            {            
                _jsonAction.Write<PersonalInformation>(tempList, filePath);
            }
            catch(Exception e)
            {
                // log error top logger
            }
        }
    }
}