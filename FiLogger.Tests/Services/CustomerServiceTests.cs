using CryptoLib;
using FiLogger.Common.Models;
using FiLogger.DataAccess.Repositories;
using FiLogger.Service.Services;
using FiLogger.Tests.MockData;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace FiLogger.Tests.Services
{
    [TestClass]
    public class CustomerServiceTests
    {
        private MockRepository mockRepository;

        private Mock<ICustomerRepository> mockCustomerRepository;
        private Mock<ILogger<CustomerService>> mockLogger;

        [TestInitialize]
        public void TestInitialize()
        {
            mockRepository = new MockRepository(MockBehavior.Default);
            mockLogger = mockRepository.Create<ILogger<CustomerService>>();

            mockCustomerRepository = mockRepository.Create<ICustomerRepository>();          

            mockCustomerRepository.Setup(x => x.AddCustomer(It.IsAny<CustomerDetails>())).Returns(MockCustomerData.MockCustomerDetails);
            mockCustomerRepository.Setup(x => x.CustomerDetailsExists(It.IsAny<int>())).Returns(true);
            mockCustomerRepository.Setup(x => x.DeleteVehicle(It.IsAny<int>()));
            mockCustomerRepository.Setup(x => x.GetCustomerDetails()).Returns(Task.FromResult(MockCustomerData.MockCustomerDetailsList()));
            mockCustomerRepository.Setup(x => x.GetCustomerDetails(It.IsAny<int>())).Returns(Task.FromResult(MockCustomerData.MockCustomerDetails()));
            mockCustomerRepository.Setup(x => x.UpdateCustomer(MockCustomerData.MockCustomerDetails()));

        }
    

        private CustomerService CreateService()
        {
            return new CustomerService(
                mockCustomerRepository.Object,  
                mockLogger.Object);
        }

        [TestMethod]
        public async Task GetCustomerDetails_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateService();
            string expected = JsonConvert.SerializeObject(MockCustomerData.MockCustomerDetailsList());

            // Act
            var result = await unitUnderTest.GetCustomerDetails();
            var jsonResult = JsonConvert.SerializeObject(result);

            // Assert
            Assert.AreEqual(expected, jsonResult);

        }

        [TestMethod]
        public async Task GetCustomerDetails_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = CreateService();
            int id = 1;
            string expected = JsonConvert.SerializeObject(MockCustomerData.MockCustomerDetails());

            // Act
            var result = await unitUnderTest.GetCustomerDetails(
                id);
            var jsonResult = JsonConvert.SerializeObject(result);

            // Assert
            Assert.AreEqual(expected, jsonResult);
          }

        [TestMethod]
        public async Task UpdateCustomerDetails_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateService();
            int id = 1;
            CustomerDetails customerDetails = MockCustomerData.MockCustomerDetails();
            string expected = JsonConvert.SerializeObject(MockCustomerData.MockCustomerDetails());
            // Act
            var result = await unitUnderTest.UpdateCustomerDetails(
                id,
                customerDetails);

            var jsonResult = JsonConvert.SerializeObject(result);
            // Assert
           
        }

        [TestMethod]
        public async Task CreateCustomerDetails_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateService();
            CustomerDetails customerDetails = MockCustomerData.MockCustomerDetails();


            // Act
            var result = await unitUnderTest.CreateCustomerDetails(
                customerDetails);

            // Assert
            if (result.CustomerId != 1)
            { 
                Assert.Fail();
            }
        }

        [TestMethod]
        public async Task DeleteCustomerDetails_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = CreateService();
            int id = 1;

            // Act
            var result = await unitUnderTest.DeleteCustomerDetails(
                id);

            if (!result) Assert.Fail();


          
        }
    }
}
