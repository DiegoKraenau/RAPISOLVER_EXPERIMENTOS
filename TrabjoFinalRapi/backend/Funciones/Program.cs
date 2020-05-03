using RapiSolver.Entity;
using System;
using System.Collections.Generic;

namespace Funciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }


        public static bool validarCreacionSupplier(Supplier supplier,List<Supplier> ListaSuppliers)
        {
            int cont = 0;
            if(supplier.UsuarioId!=0 && supplier.Name.Length>3 && supplier.LastName.Length>3 &&
                supplier.Email.Length>10 && supplier.Contraseña.Length>7 && supplier.SupplierId!=0 &&
                Convert.ToInt32(supplier.Age) >= 18 && supplier.UsuarioId==supplier.SupplierId)
            {
                foreach(Supplier supp in ListaSuppliers)
                {
                    if(supp.UsuarioId==supplier.UsuarioId || supp.Email==supplier.Email || supp.SupplierId == supplier.SupplierId)
                    {
                        cont += 1;
                    }
                    
                }

                if (cont == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
    }
}
