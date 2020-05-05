using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class RolRepositoryMock
    {
        public Mock<IRolRepository> rolRepository { get; set; }

        public RolRepositoryMock()
        {
            rolRepository = new Mock<IRolRepository>();
            Setup();

        }

        private void Setup()
        {

            rolRepository.Setup((x) => x.Save(It.IsAny<Rol>())).Returns(true);
            rolRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(RolStub.rol_1);
            rolRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            rolRepository.Setup((x) => x.GetAll()).Returns(RolStub.rolList);
            rolRepository.Setup((x) => x.Update(It.IsAny<Rol>())).Returns(true);

        }

    }
}
