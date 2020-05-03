using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class LocationStub
    {
         public static Location location_1 = new Location()
         {
         LocationId = 1,


          Country = "Lima",


          City = "Lima",


          State ="Lima",


          Address ="av.Venezuela"
         };

        public static Location location_2 = new Location()
        {
            LocationId = 2,


            Country = "Lima",


            City = "Lima",


            State = "Lima",


            Address = "av.Venezuela"
        };
        public static List<Location> locationList = new List<Location>(new Location[] { location_1, location_2 });

    }
}
