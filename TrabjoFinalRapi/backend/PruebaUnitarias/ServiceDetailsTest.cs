using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PruebaUnitarias.MockRepositories;
using PruebaUnitarias.Stubs;
using RapiSolver.Repository;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    [TestClass]
    public class ServiceDetailsTest
    {
        private static IServiceDetailsService _serviceDetailService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IServiceDetailsRepository> _serviceDetailRepository = new ServiceDeatilsRepositoryMock().serviceDeatilsRepository;

            _serviceDetailService = new ServiceDetailsService(_serviceDetailRepository.Object);

        }

        [TestMethod]
        public void Save_ObjServiceDetail_ReturnTrue()
        {

            var result = _serviceDetailService.Save(ServiceDetailsStub.serviceDetails_1);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GetAll_Empty_ReturnRolList()
        {

            var result = _serviceDetailService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);


        }


        [TestMethod]
        public void GetById_SingleNumber_ReturnServiceDetail()
        {
            var result = _serviceDetailService.Get(1);

            result.ServiceDetailsId.Should().Be(1);
            result.SupplierId.Should().BePositive();

        }

        [TestMethod]
        public void UpdateById_ObjServiceDetail_ReturnTrue()
        {
            var result = _serviceDetailService.Update(ServiceDetailsStub.serviceDetails_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _serviceDetailService.Delete(1);
            Assert.AreEqual(true, result);

        }
    }
}
