using Microsoft.VisualStudio.TestTools.UnitTesting;
using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    [TestClass]
    public class UsuarioTest
    {
        private List<Usuario> ListaUsuarios = new List<Usuario>();


        [TestInitialize]
        public void inicializador()
        {
            
            Usuario usuario1 = new Usuario()
            {
                UsuarioId = 1,
                UserName = "diegokraenau@gmail.com",
                UserPassword = "diego2009",
                RolId = 1
            };

            Usuario usuario2 = new Usuario()
            {
                UsuarioId = 2,
                UserName = "carlos@gmail.com",
                UserPassword = "carlos2009",
                RolId = 2
            };

            ListaUsuarios.Add(usuario1);
            ListaUsuarios.Add(usuario2);
        }

        [TestMethod]
        public void validarCreacionUsuarioTest()
        {
            


            //Prueba
            Usuario usuario = new Usuario();

            bool resultado = Metodos.validarCreacionUsuario(3, "diegokraenau3@gmail.com", "diego2009", 1, ListaUsuarios);

            Assert.AreEqual(true, resultado);


        }

        [TestMethod]
        public void loginUsuarioTest()
        {
            Usuario usuario = new Usuario();
            Usuario resultado = Metodos.loginUsuario("diegokraenau@gmail.com", "diego2009", ListaUsuarios);

            Assert.IsNotNull(resultado);
        }
    }
}
