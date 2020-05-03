using Microsoft.VisualStudio.TestTools.UnitTesting;
using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    [TestClass]
    public class ServiceDetailsTest
    {

        private List<ServiceDetails> ListaServiceDeatils = new List<ServiceDetails>();
        Supplier supplier1 = new Supplier();
        Supplier supplier2 = new Supplier();
        ServiceCategory categoria1 = new ServiceCategory();
        ServiceCategory categoria2 = new ServiceCategory();
        ServiceCategory categoria3 = new ServiceCategory();
        Servicio servicio1 = new Servicio();
        Servicio servicio2 = new Servicio();
        Servicio servicio3 = new Servicio();
        ServiceDetails detail1 = new ServiceDetails();
        ServiceDetails detail2 = new ServiceDetails();
        ServiceDetails detail3 = new ServiceDetails();

     [TestInitialize]
        public void inicializador()
        {
            //Suppliers
             supplier1 = new Supplier()
            {
                UsuarioId = 1,
                Name = "Diego",
                LastName = "Kraenau",
                Email = "diegokraenau@gmail.com",
                Contraseña = "diego2009",
                SupplierId = 1,
                Age = "19"


            };

            supplier2 = new Supplier()
            {
                UsuarioId = 2,
                Name = "Carlos",
                LastName = "Castilla",
                Email = "carlos@gmail.com",
                Contraseña = "carlos2009",
                SupplierId = 2,
                Age = "22"
            };

            //Categorias

            categoria1 = new ServiceCategory()
            {
                ServiceCategoryId = 1,
                CategoryName = "Electricidad",
                CategoryDescription = "Servicios de Electricidad"
            };

            categoria2 = new ServiceCategory()
            {
                ServiceCategoryId = 2,
                CategoryName = "Jardineria",
                CategoryDescription = "Servicios de Jardineria"
            };

            categoria3 = new ServiceCategory()
            {
                ServiceCategoryId = 3,
                CategoryName = "Gasfiteria",
                CategoryDescription = "Servicios de Gasfiteria"
            };

            //Servicios

            servicio1 = new Servicio() {
                ServicioId = 1,
                ServiceCategory =categoria1,
                Cost="40",
                Description="Mejores servicios",
                Name="Electricista",
                ServiceCategoryId=categoria1.ServiceCategoryId
                
            };


            servicio2 = new Servicio()
            {
                ServicioId = 2,
                ServiceCategory = categoria2,
                Cost = "30",
                Description = "Mejores servicios",
                Name = "Jardinero",
                ServiceCategoryId = categoria2.ServiceCategoryId

            };

            servicio3 = new Servicio()
            {
                ServicioId = 3,
                ServiceCategory = categoria3,
                Cost = "60",
                Description = "Mejores servicios",
                Name = "Gasfitero",
                ServiceCategoryId = categoria3.ServiceCategoryId

            };


            //ServiceDetails

            detail1 = new ServiceDetails() { 
                ServiceDetailsId=servicio1.ServicioId,
                Servicio=servicio1,
                ServicioId=servicio1.ServicioId,
                Supplier=supplier1,
                SupplierId=supplier1.SupplierId
            };

            detail2 = new ServiceDetails() { 
                ServiceDetailsId=servicio2.ServicioId,
                Servicio=servicio2,
                ServicioId=servicio2.ServicioId,
                Supplier=supplier2,
                SupplierId=supplier2.SupplierId
            };

            // Poblar listar de ServiceDetails
            ListaServiceDeatils.Add(detail1);
            ListaServiceDeatils.Add(detail2);


           
             

        }

        [TestMethod]
        public void validarCreacionServiceDeatilsTest()
        {
            detail3 = new ServiceDetails()
            {
                ServiceDetailsId = servicio3.ServicioId,
                Servicio = servicio3,
                ServicioId = servicio3.ServicioId,
                Supplier = supplier1,
                SupplierId = supplier1.SupplierId
            };

            bool resultado = Metodos.validarCreacionServiceDeatils(detail3, ListaServiceDeatils);
            Assert.AreEqual(true, resultado);
        }

    }
}
