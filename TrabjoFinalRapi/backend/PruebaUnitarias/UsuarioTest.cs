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
    public class UsuarioTest
    {
        private static IUsuarioService _usuarioService;

        [ClassInitialize()]
        public static void Setup(TestContext context)
        {
            Mock<IUsuarioRepository> _usuarioRepository = new UsuarioRepositoryMock().usuarioRepository;

            _usuarioService = new UsuarioService(_usuarioRepository.Object);

        }


        [TestMethod]
        public void Save_ObjUsuario_ReturnTrue()
        {

            var result = _usuarioService.Save(UsuarioStub.usuario_1);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GetAll_Empty_ReturnUsuarioList()
        {

            var result = _usuarioService.GetAll();
            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCountGreaterOrEqualTo(2);


        }


        [TestMethod]
        public void GetById_SingleNumber_ReturnUsuario()
        {
            var result = _usuarioService.Get(1);

            result.UsuarioId.Should().Be(1);
            result.UserName.Should().NotBeNullOrEmpty();

        }

        [TestMethod]
        public void UpdateById_ObjUsuario_ReturnTrue()
        {
            var result = _usuarioService.Update(UsuarioStub.usuario_1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DeleteById_SingleNumber_ReturnTrue()
        {

            var result = _usuarioService.Delete(1);
            Assert.AreEqual(true, result);

        }

    }
}
