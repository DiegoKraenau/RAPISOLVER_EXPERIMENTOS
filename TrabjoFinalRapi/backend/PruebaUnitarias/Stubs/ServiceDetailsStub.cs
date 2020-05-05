using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class ServiceDetailsStub
    {
        public static ServiceDetails serviceDetails_1 = new ServiceDetails()
        {
            ServiceDetailsId=1,
            ServicioId=1,
            SupplierId=2

        };

        public static ServiceDetails serviceDetails_2 = new ServiceDetails()
        {
            ServiceDetailsId = 2,
            ServicioId = 2,
            SupplierId = 1

        };

        public static List<ServiceDetails> serviceDetailsList = new List<ServiceDetails>(new ServiceDetails[] { serviceDetails_1, serviceDetails_2 });
    }
}
