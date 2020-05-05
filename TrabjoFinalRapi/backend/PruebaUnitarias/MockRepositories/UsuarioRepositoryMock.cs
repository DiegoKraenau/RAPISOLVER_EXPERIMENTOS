using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class UsuarioRepositoryMock
    {
        public Mock<IUsuarioRepository> usuarioRepository { get; set; }


        public UsuarioRepositoryMock()
        {
            usuarioRepository = new Mock<IUsuarioRepository>();
            Setup();

        }


        private void Setup()
        {

            usuarioRepository.Setup((x) => x.Save(It.IsAny<Usuario>())).Returns(true);
            usuarioRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(UsuarioStub.usuario_1);
            usuarioRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            usuarioRepository.Setup((x) => x.GetAll()).Returns(UsuarioStub.usuarioList);
            usuarioRepository.Setup((x) => x.Update(It.IsAny<Usuario>())).Returns(true);

        }

    }
}
