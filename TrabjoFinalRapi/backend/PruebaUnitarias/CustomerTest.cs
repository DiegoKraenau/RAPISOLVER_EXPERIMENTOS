using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PruebaUnitarias.MockRepositories;
using PruebaUnitarias.Stubs;
using RapiSolver.Api.Controllers;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using System.Collections;
using System.Collections.Generic;

namespace PruebaUnitarias
{
    [TestClass]
    public class CustomerTest
    {
        private static ICustomerService _customerService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<ICustomerRepository> _customerRepository = new CustomerRepositoryMock().customerRepository;

            _customerService = new CustomerService(_customerRepository.Object);

        }
        [TestMethod]
        public void Save_ObjCustomer_ReturnTrue()
        {
            
            var result = _customerService.Save(CustomerStub.customer_1);
            Assert.AreEqual(true, result);

        }
      
        [TestMethod]
        public void GetAll_Empty_ReturnCustomerList()
        {

            var result = _customerService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);


        }
        [TestMethod]
        public void GetById_SingleNumber_ReturnCustomer()
        {
            var result = _customerService.Get(1);

            result.CustomerId.Should().Be(1);
            result.Name.Should().NotBeNullOrEmpty();
       
        }

        [TestMethod]
        public void UpdateById_ObjCustomer_ReturnTrue()
        {
            var result = _customerService.Update(CustomerStub.customer_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _customerService.Delete(1);
            Assert.AreEqual(true, result);

        }
    }
        



}
