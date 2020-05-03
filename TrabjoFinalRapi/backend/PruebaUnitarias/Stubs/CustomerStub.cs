using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias.Stubs
{
    public static class CustomerStub
    {
        public static Customer customer_1 = new Customer()
        {
            CustomerId= 1,
            Name = "Carlos",
            LastName = "Castilla",
            Email = "cas.0@gmail.com",
            Phone = "946144467",


            Age = "100",


            Genger = "M",


            Country = "Malaga",

            State = "Malaga",

            City = "Malaga",

            Address = "AV",

            Contraseña = "password"
        };
        public static Customer customer_2 = new Customer()
        {
            CustomerId = 2,
            Name = "Liliana",
            LastName = "Flores",
            Email = "ly0@gmail.com",
            Phone = "123456789",


            Age = "100",


            Genger = "F",


            Country = "Malaga",

            State = "Malaga",

            City = "Malaga",

            Address = "AV",

            Contraseña = "password"
        };



        public static List<Customer> customerList = new List<Customer>(new Customer[] { customer_1, customer_2 });

    }
}
