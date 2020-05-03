using Microsoft.VisualStudio.TestTools.UnitTesting;
using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    [TestClass]
    public class SupplierTest
    {
        private List<Supplier> ListaSuppliers = new List<Supplier>();
        

        [TestInitialize]
        public void inicializador()
        {

            Supplier supplier1 = new Supplier()
            {
                UsuarioId = 1,
                Name = "Diego",
                LastName = "Kraenau",
                Email = "diegokraenau@gmail.com",
                Contraseña="diego2009",
                SupplierId=1,
                Age="19"


            };

            Supplier supplier2 = new Supplier()
            {
                UsuarioId = 2,
                Name = "Carlos",
                LastName = "Castilla",
                Email = "carlos@gmail.com",
                Contraseña = "carlos2009",
                SupplierId = 2,
                Age = "22"
            };

            ListaSuppliers.Add(supplier1);
            ListaSuppliers.Add(supplier2);
        }

        [TestMethod]
        public void validarCreacionSupplierTest()
        {
            Supplier supplier3 = new Supplier()
            {
                UsuarioId = 3,
                Name = "Guillermo",
                LastName = "Rosales",
                Email = "guillermo@gmail.com",
                Contraseña = "guillermo2009",
                SupplierId = 3,
                Age = "21"
            };
            
            
            var resultado = Metodos.validarCreacionSupplier(supplier3,ListaSuppliers);

            Assert.AreEqual(true, resultado);
        }

    }
}
