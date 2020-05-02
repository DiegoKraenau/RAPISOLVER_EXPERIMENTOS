using System.Collections.Generic;
using RapiSolver.Entity;

namespace RapiSolver.Repository.ViewModel
{
    public class SupplierViewModel
    {
         public int SupplierId{get;set;}
        public string Name{get;set;}

       
        public string LastName{get;set;}

      
        public string Email{get;set;}

     
        public string Phone{get;set;}

         
        public string Age{get;set;}

         
        public string Genger{get;set;}

        public int UsuarioId{get;set;}

        public int LocationId{get;set;} 

        public string UserName{get;set;}

        public string Country{get;set;}

         public  IEnumerable<ServiceDetails> ServiciosDetails{get;set;}
    }
}