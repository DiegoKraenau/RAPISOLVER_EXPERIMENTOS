using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RapiSolver.Api.Controllers;
using RapiSolver.Entity;
using RapiSolver.Service;
using System.Collections;
using System.Collections.Generic;

namespace PruebaUnitarias
{
    [TestClass]
    public class RolTest
    {
        /*
        [TestMethod]
        public void get()
        {

            var role = new Rol()
            {
                RolId = 4,
                RolDescription = "No puede publicar",
                Publish = false
            };

            IRolService rolservice=null;
            
            var g = rolservice.Save(role);



            var mock = new Mock<IRolService>();
            mock.Setup(x => x.GetAll()).Returns(default(IEnumerable<Rol>));
            var roleController = new RolesController(mock.Object);

            var resultado = roleController.Get();

            Assert.IsInstanceOfType(resultado, typeof(NotFoundResult));

        }
        */


        [TestMethod]
        public void ingresarRolTest()
        {
            Rol rol = new Rol();

            bool resultado = Metodos.ingresarRol(1, "Puede publicar", true);

            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void getRolById()
        {
            var rol = new Rol()
            {
                RolId = 1,
                RolDescription="Puede publicar",
                Publish=true
            
            };
            var rol2 = new Rol()
            {
                RolId = 2,
                RolDescription = "No puede publicar",
                Publish = false
            };

            List<Rol> listaRoles = new List<Rol>();
            listaRoles.Add(rol);
            listaRoles.Add(rol2);


            //Resultado

            var rolObtenido = new Rol();
            var resultado = Metodos.getRolById(listaRoles, 1);

            Assert.AreNotEqual(null, resultado);

        }
        



    }
}
