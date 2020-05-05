using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class SupplierStub
    {
        public static Supplier supplier_1 = new Supplier()
        {
            SupplierId=1,
            UsuarioId=1,
            Name = "Diego",
            LastName = "Kraenau",
            Email = "diegokraenai0@gmail.com",
            Phone = "946144467",
            Age = "19",
            Genger = "M",
            Country = "Malaga",
            State = "Malaga",
            City = "Malaga",
            Address = "AV",
            Contraseña = "diego2009"
        };

        public static Supplier supplier_2 = new Supplier()
        {
            SupplierId = 2,
            UsuarioId = 2,
            Name = "Juan",
            LastName = "Ramirez",
            Email = "juancito@gmail.com",
            Phone = "946144467",
            Age = "50",
            Genger = "M",
            Country = "Malaga",
            State = "Malaga",
            City = "Malaga",
            Address = "AV",
            Contraseña = "juan2009"
        };

        public static List<Supplier> supplierList = new List<Supplier>(new Supplier[] { supplier_1, supplier_2 });
    }
}
