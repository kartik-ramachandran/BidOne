using BidOne.Business;
using BidOne.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BidOne.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class PersonalInformationController : ControllerBase
    {
        private readonly ILogger<PersonalInformationController> _logger;
        private readonly IWrite _write;

        public PersonalInformationController(ILogger<PersonalInformationController> logger, 
            IWrite write)
        {
            _logger = logger;
            _write = write;
        }

        [HttpPost]
        public void SubmitInfomation([FromBody] PersonalInformationModel modelData)
        {
            var personalInformation = new PersonalInformation();
            personalInformation.FirstName = modelData.FirstName;
            personalInformation.LastName = modelData.LastName;

            _write.ToJson(personalInformation, @"D:\TestData\PersonalInformation.json");
        }
    }

    public class PersonalInformationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}