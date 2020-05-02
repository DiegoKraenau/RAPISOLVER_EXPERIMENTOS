using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/rapiusers")]
    [ApiController]

    public class UsuariosController: ControllerBase
    {
        private IUsuarioService usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

         /// <summary>
        /// It allows  to obtain all the users that were added
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                usuarioService.GetAllUsuarios()
            );
        }

        /// <summary>
        /// It allows to add a user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            return Ok(
                usuarioService.Save(usuario)
            );
        }

        /// <summary>
        /// It allows to search a user by their corresponding Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                usuarioService.Get(id)
            );
        }

         /// <summary>
        /// It allows to update the role of  a user by their user ID
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Put(int id)
        {
            return Ok(
                usuarioService.UpdateRole(id)
            );
        }

    }
}