using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class ServiciosStub
    {
        public static Servicio servicio_1 = new Servicio()
        {
            ServicioId = 1,
            Name = "Servicio Financiero",
            Description = "Actividades Financiera",
            Cost = "1500"
        };

        public static Servicio servicio_2 = new Servicio()
        {
            ServicioId = 2,
            Name = "Servicio Publico",
            Description = "Administraciones publicas",
            Cost = "2000"
        };

        public static List<Servicio> servicioList = new List<Servicio>(new Servicio[] { servicio_1, servicio_2 });
    }
}
