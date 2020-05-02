using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private ApplicationDbContext context;

        public UsuarioRepository (ApplicationDbContext context) {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Get(int id)
        {
             var result = new Usuario();
            try
            {
                result = context.usuarios.Find(id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new System.NotImplementedException();
        }

         public IEnumerable<UsuarioViewModel> GetAllUsuarios()
        {
            var usuario = context.usuarios
                .Include (o => o.Rol)
                .OrderByDescending (o => o.RolId)
                .ToList ();

            return usuario.Select (o => new UsuarioViewModel {
                UsuarioId = o.UsuarioId,
                    UserName = o.UserName,
                    UserPassword = o.UserPassword,
                    RolId = o.Rol.RolId
             });
        }

        public UsuarioViewModel getLoginUsuario(string name, string password)
        {
             var usuario = context.usuarios.
                            Include(x=>x.Rol).
                            Single(x => x.UserName==name && x.UserPassword ==password);

            UsuarioViewModel usuario1=new UsuarioViewModel();
            usuario1.UsuarioId=usuario.UsuarioId;
            usuario1.UserName=usuario.UserName;
            usuario1.UserPassword=usuario.UserPassword;
            usuario1.RolId=usuario.RolId;

            return usuario1;
        }

        public bool Save(Usuario entity)
        {
            try
            {
                entity.Rol=context.roles.Find(entity.RolId);
                
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateRole(int id)
        {
            try
            {
                Usuario u1=context.usuarios.Find(id);
                Rol r1=context.roles.Find(2);
                u1.Rol=r1;
                u1.RolId=2;
                
                
                context.usuarios.Update(u1);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }
    }
}