using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class SupplierRepositoryMock
    {
        public Mock<ISupplierRepository> supplierRepository { get; set; }

        public SupplierRepositoryMock()
        {
            supplierRepository = new Mock<ISupplierRepository>();
            Setup();

        }

        private void Setup()
        {

            supplierRepository.Setup((x) => x.Save(It.IsAny<Supplier>())).Returns(true);
            supplierRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(SupplierStub.supplier_1);
            supplierRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            supplierRepository.Setup((x) => x.GetAll()).Returns(SupplierStub.supplierList);
            supplierRepository.Setup((x) => x.Update(It.IsAny<Supplier>())).Returns(true);

        }
    }
}
