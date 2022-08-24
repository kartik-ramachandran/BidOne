using BidOne.Business;
using BidOne.Json;
using Microsoft.Extensions.DependencyInjection;

namespace BidOne.UnitTest
{
    public class Tests
    {
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
                        
            services.AddTransient<IJsonAction, JsonAction>();
            services.AddTransient<IWrite, Write>();

            _serviceProvider = services.BuildServiceProvider();
        }
    
        [Test]
        public void Test1()
        {
            var _write = _serviceProvider.GetService<IWrite>();

            _write?.ToJson(new Domain.PersonalInformation
            {
                FirstName = "Test",
                LastName = "Test"
            }, @"D:\TestData\PersonalInformation.json");

            Assert.Pass();
        }
    }
}