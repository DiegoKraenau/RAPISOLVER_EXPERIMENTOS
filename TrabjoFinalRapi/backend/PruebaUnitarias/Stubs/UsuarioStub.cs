using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class UsuarioStub
    {
        public static Usuario usuario_1 = new Usuario()
        {
            UsuarioId=1,
            UserName="diegokraenau@gmail.com",
            UserPassword="diego2009",
            RolId=1
        };

        public static Usuario usuario_2 = new Usuario()
        {
            UsuarioId = 2,
            UserName = "carlos@gmail.com",
            UserPassword = "carlos",
            RolId = 2
        };

        public static List<Usuario> usuarioList = new List<Usuario>(new Usuario[] { usuario_1, usuario_2 });
    }
}
