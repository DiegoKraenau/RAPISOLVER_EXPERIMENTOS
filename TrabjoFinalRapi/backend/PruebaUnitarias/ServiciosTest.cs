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
    public class ServiciosTest
    {
        private static IServicioService _servicioService;

        [ClassInitialize()]

        public static void Setup(TestContext context)
        {
            Mock<IServicioRepository> _servicioRepository = new ServiciosRepositoryMock().servicioRepository;
            _servicioService = new ServicioService(_servicioRepository.Object);
        }

        [TestMethod]
        public void Save_ObjServicio_ReturnTrue()
        {

            var result = _servicioService.Save(ServiciosStub.servicio_1);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GetAll_Empty_ReturnServicioList()
        {

            var result = _servicioService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);

        }
        [TestMethod]
        public void GetById_SingleNumber_ReturnServicio()
        {
            var result = _servicioService.Get(1);
            result.ServicioId.Should().Be(1);
            result.Name.Should().NotBeNullOrEmpty();
            result.Description.Should().NotBeNullOrEmpty();
            result.Cost.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void UpdateById_ObjServicio_ReturnTrue()
        {
            var result = _servicioService.Update(ServiciosStub.servicio_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _servicioService.Delete(1);
            Assert.AreEqual(true, result);

        }
    }
}
