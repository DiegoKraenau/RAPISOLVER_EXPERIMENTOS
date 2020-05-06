using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class ServiceCategoriesRepositoryMock
    {
        public Mock<IServiceCategoryRepository> servicecategoryRepository { get; set; }

        public ServiceCategoriesRepositoryMock()
        {
            servicecategoryRepository = new Mock<IServiceCategoryRepository>();
            Setup();
        }

        private void Setup()
        {
            servicecategoryRepository.Setup((x) => x.Save(It.IsAny<ServiceCategory>())).Returns(true);
            servicecategoryRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(ServiceCategoriesStub.servicecategory_1);
            servicecategoryRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            servicecategoryRepository.Setup((x) => x.GetAll()).Returns(ServiceCategoriesStub.serviceCategoriesList);
            servicecategoryRepository.Setup((x) => x.Update(It.IsAny<ServiceCategory>())).Returns(true);
        }
    }
}

