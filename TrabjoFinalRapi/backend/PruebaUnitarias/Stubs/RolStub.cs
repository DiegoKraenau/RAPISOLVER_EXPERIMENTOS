using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class RolStub
    {
        public static Rol rol_1 = new Rol()
        {
            RolId=1,
            RolDescription="Puede publicar",
            Publish=true,
            Usuarios=null
        };

        public static Rol rol_2 = new Rol()
        {
            RolId = 1,
            RolDescription = "Puede publicar",
            Publish = true,
            Usuarios = null
        };

        public static List<Rol> rolList = new List<Rol>(new Rol[] { rol_1, rol_2 });
    }
}
