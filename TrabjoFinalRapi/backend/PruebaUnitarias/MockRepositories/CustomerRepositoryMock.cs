using Moq;
using PruebaUnitarias.Stubs;
using RapiSolver.Entity;
using RapiSolver.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.MockRepositories
{
    class CustomerRepositoryMock
    {
        public Mock<ICustomerRepository> customerRepository { get; set; }

        public CustomerRepositoryMock()
        {
            customerRepository = new Mock<ICustomerRepository>();
            Setup();

        }

        private void Setup()
        {
            
            customerRepository.Setup((x) => x.Save(It.IsAny<Customer>())).Returns(true);
            customerRepository.Setup((x) => x.Get(It.IsAny<int>())).Returns(CustomerStub.customer_1);
            customerRepository.Setup((x) => x.Delete(It.IsAny<int>())).Returns(true);
            customerRepository.Setup((x) => x.GetAll()).Returns(CustomerStub.customerList);
            customerRepository.Setup((x) => x.Update(It.IsAny<Customer>())).Returns(true);
           
        }
    }
}
