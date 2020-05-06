using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class ServiciosRepositoryMock
    {
        public Mock<IServicioRepository> servicioRepository { get; set; }

        public ServiciosRepositoryMock()
        {
            servicioRepository = new Mock<IServicioRepository>();
            Setup();
        }

        private void Setup()
        {
            servicioRepository.Setup((x) => x.Save(It.IsAny<Servicio>())).Returns(true);
            servicioRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(ServiciosStub.servicio_1);
            servicioRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            servicioRepository.Setup((x) => x.GetAll()).Returns(ServiciosStub.servicioList);
            servicioRepository.Setup((x) => x.Update(It.IsAny<Servicio>())).Returns(true);
        }
    }
}
