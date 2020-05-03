using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class LocationRepositoryMock
    {
        public Mock<ILocationRepository> locationRepository { get; set; }

        public LocationRepositoryMock()
        {
            locationRepository = new Mock<ILocationRepository>();
            Setup();
        }

        private void Setup()
        {

            locationRepository.Setup((x) => x.Save(It.IsAny<Location>())).Returns(true);
            locationRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(LocationStub.location_1);
            locationRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            locationRepository.Setup((x) => x.GetAll()).Returns(LocationStub.locationList);
            locationRepository.Setup((x) => x.Update(It.IsAny<Location>())).Returns(true);

        }
    }
}
