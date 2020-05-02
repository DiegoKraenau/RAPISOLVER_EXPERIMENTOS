using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/roles")]
    [ApiController]

    public class RolesController: ControllerBase
    {
        private IRolService rolService;

        public RolesController(IRolService rolService)
        {
            this.rolService = rolService;
        }

        /// <summary>
        /// It allows to obtain all the roles 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            var roles = rolService.GetAll();
            if (roles == null)
            {
                return NotFound();
            }


            return Ok(
                rolService.GetAll()
            );
        }


        /// <summary>
        /// It allows to add a role
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Rol rol)
        {
            return Ok(
                rolService.Save(rol)
            );
        }


        /// <summary>
        /// It allows  to search for a role by their corresponding Id
        /// </summary>
        /// <returns></returns>       
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                rolService.Get(id)
            );
        }
        
    }
}