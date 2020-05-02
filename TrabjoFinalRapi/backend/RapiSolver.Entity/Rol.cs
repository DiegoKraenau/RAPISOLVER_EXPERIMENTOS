using System.Collections.Generic;

namespace RapiSolver.Entity
{
    public class Rol
    {
        
        public int RolId{get;set;}

        
        public string RolDescription{get;set;}

        public bool Publish{get;set;}

        public List<Usuario> Usuarios{get;set;}

        public bool ingresarRol(int id,string rolDescription,bool publish)
        {
   

            if (id > 0 && rolDescription.Length<=30  )
            {
                if (id == 1 && publish==true)
                {
                    return true;
                }
                else if(id==2 && publish == false)
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

        public Rol getRolById(List<Rol> roles,int id)
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