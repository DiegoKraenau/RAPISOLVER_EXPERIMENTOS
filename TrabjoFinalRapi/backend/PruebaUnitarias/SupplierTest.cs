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
    public class SupplierTest
    {
        private static ISupplierService _supplierService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<ISupplierRepository> _supplierRepository = new SupplierRepositoryMock().supplierRepository;

            _supplierService = new SupplierService(_supplierRepository.Object);

        }

        [TestMethod]
        public void Save_ObjSupplier_ReturnTrue()
        {

            var result = _supplierService.Save(SupplierStub.supplier_1);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GetAll_Empty_ReturnSupplierList()
        {

            var result = _supplierService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);


        }

        [TestMethod]
        public void GetById_SingleNumber_ReturnSupplier()
        {
            var result = _supplierService.Get(1);

            result.SupplierId.Should().Be(1);
            result.Name.Should().NotBeNullOrEmpty();

        }

        [TestMethod]
        public void UpdateById_ObjSupplier_ReturnTrue()
        {
            var result = _supplierService.Update(SupplierStub.supplier_1);
            Assert.AreEqual(true, result);
        }
    }
}
