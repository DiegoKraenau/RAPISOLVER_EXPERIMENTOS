using RapiSolver.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaUnitarias
{
    public class Metodos
    {
        public static bool validarCreacionSupplier(Supplier supplier, List<Supplier> ListaSuppliers)
        {
            int cont = 0;
            if (supplier.UsuarioId != 0 && supplier.Name.Length > 3 && supplier.LastName.Length > 3 &&
                supplier.Email.Length > 10 && supplier.Contraseña.Length > 7 && supplier.SupplierId != 0 &&
                Convert.ToInt32(supplier.Age) >= 18 && supplier.UsuarioId == supplier.SupplierId)
            {
                foreach (Supplier supp in ListaSuppliers)
                {
                    if (supp.UsuarioId == supplier.UsuarioId || supp.Email == supplier.Email || supp.SupplierId == supplier.SupplierId)
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
    
        public static bool validarCreacionServiceDeatils(ServiceDetails serviceDetails,List<ServiceDetails> ListaServicesDeatils)
        {
            int cont = 0;
            if(serviceDetails.ServiceDetailsId!=0 && serviceDetails.ServiceDetailsId==serviceDetails.Servicio.ServicioId && serviceDetails.SupplierId != 0)
            {
                foreach(ServiceDetails SD in ListaServicesDeatils)
                {
                    if(serviceDetails.ServiceDetailsId==SD.ServiceDetailsId || serviceDetails.ServicioId==SD.ServicioId)
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

        public static bool validarCreacionUsuario(int UsuarioId, string UserName, string UserPassword, int RolId, List<Usuario> ListaUsuarios)
        {
            if (UsuarioId > 0 && RolId > 0 && UserName.Length > 10 && UserPassword.Length > 7)
            {
                int cont = 0;
                foreach (Usuario usuario in ListaUsuarios)
                {
                    if (usuario.UserName == UserName || usuario.UsuarioId == UsuarioId)
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

        public static Usuario loginUsuario(string UserName, string UserPassword, List<Usuario> ListaUsuarios)
        {
            Usuario usuario = new Usuario();
            usuario = null;

            if (UserName.Length > 10 && UserPassword.Length > 7)
            {
                foreach (Usuario user in ListaUsuarios)
                {
                    if (user.UserName == UserName && user.UserPassword == UserPassword)
                    {

                        usuario = user;
                    }
                }
                return usuario;
            }
            else
            {
                return usuario;
            }
        }

        public static bool ingresarRol(int id, string rolDescription, bool publish)
        {


            if (id > 0 && rolDescription.Length <= 30)
            {
                if (id == 1 && publish == true)
                {
                    return true;
                }
                else if (id == 2 && publish == false)
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

        public static Rol getRolById(List<Rol> roles, int id)
        {
            Rol devolver = null;
            if (id > 0)
            {
                int codigo = 0;
                foreach (Rol rol in roles)
                {
                    if (rol.RolId == id)
                    {
                        devolver = rol;
                        codigo = id;
                    }
                }

            }

            return devolver;

        }


    }
}
