using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class ServiceDeatilsRepositoryMock
    {
        public Mock<IServiceDetailsRepository> serviceDeatilsRepository { get; set; }

        public ServiceDeatilsRepositoryMock()
        {
            serviceDeatilsRepository = new Mock<IServiceDetailsRepository>();
            Setup();

        }

        private void Setup()
        {

            serviceDeatilsRepository.Setup((x) => x.Save(It.IsAny<ServiceDetails>())).Returns(true);
            serviceDeatilsRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(ServiceDetailsStub.serviceDetails_1);
            serviceDeatilsRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            serviceDeatilsRepository.Setup((x) => x.GetAll()).Returns(ServiceDetailsStub.serviceDetailsList);
            serviceDeatilsRepository.Setup((x) => x.Update(It.IsAny<ServiceDetails>())).Returns(true);

        }
    }
}
