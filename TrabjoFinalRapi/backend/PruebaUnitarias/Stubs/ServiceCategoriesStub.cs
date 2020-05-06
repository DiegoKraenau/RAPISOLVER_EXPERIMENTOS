using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class ServiceCategoriesStub
    {
        public static ServiceCategory servicecategory_1 = new ServiceCategory()
        {
            ServiceCategoryId = 1,
            CategoryName = "Financieros",
            CategoryDescription = "Actividad Comercial"
        };

        public static ServiceCategory servicecategory_2 = new ServiceCategory()
        {
            ServiceCategoryId = 2,
            CategoryName = "Publicos",
            CategoryDescription = "Administraciones publicas"
        };

        public static List<ServiceCategory> serviceCategoriesList = new List<ServiceCategory>(new ServiceCategory[] { servicecategory_1, servicecategory_2 });
    }
}
