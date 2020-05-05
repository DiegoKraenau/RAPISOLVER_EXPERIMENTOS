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
    public class RolTest
    {
        private static IRolService _rolService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IRolRepository> _rolRepository = new RolRepositoryMock().rolRepository;

            _rolService = new RolService(_rolRepository.Object);

        }

        [TestMethod]
        public void Save_ObjRol_ReturnTrue()
        {

            var result = _rolService.Save(RolStub.rol_1);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GetAll_Empty_ReturnRolList()
        {

            var result = _rolService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);


        }

        [TestMethod]
        public void GetById_SingleNumber_ReturnRol()
        {
            var result = _rolService.Get(1);

            result.RolId.Should().Be(1);
            result.RolDescription.Should().NotBeNullOrEmpty();

        }

        [TestMethod]
        public void UpdateById_ObjRol_ReturnTrue()
        {
            var result = _rolService.Update(RolStub.rol_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _rolService.Delete(1);
            Assert.AreEqual(true, result);

        }
    }
}
