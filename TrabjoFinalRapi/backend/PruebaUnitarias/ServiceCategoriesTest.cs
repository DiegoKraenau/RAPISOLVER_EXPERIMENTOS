using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PruebaUnitarias.MockRepositories;
using PruebaUnitarias.Stubs;
using RapiSolver.Repository;
using RapiSolver.Repository.implementation;
using RapiSolver.Service;
using RapiSolver.Service.implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    [TestClass]
    public class ServiceCategoriesTest
    {
        private static IServiceCategoryService _servicecategoryService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IServiceCategoryRepository> _servicecategoryRepository = new ServiceCategoriesRepositoryMock().servicecategoryRepository;
            _servicecategoryService = new ServiceCategoryService(_servicecategoryRepository.Object);

        }

        [TestMethod]
        public void Save_ObjServiceCategory_ReturnTrue()
        {
            var result = _servicecategoryService.Save(ServiceCategoriesStub.servicecategory_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetAll_Empty_ReturnServiceCategoryList()
        {

            var result = _servicecategoryService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);
        }

        [TestMethod]
        public void GetById_SingleNumber_ReturnServiceCategory()
        {
            var result = _servicecategoryService.Get(1);

            result.ServiceCategoryId.Should().Be(1);
            result.CategoryName.Should().NotBeNullOrEmpty();
            result.CategoryDescription.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void UpdateById_ObjServiceCategory_ReturnTrue()
        {
            var result = _servicecategoryService.Update(ServiceCategoriesStub.servicecategory_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _servicecategoryService.Delete(1);
            Assert.AreEqual(true, result);

        }
    }
}

