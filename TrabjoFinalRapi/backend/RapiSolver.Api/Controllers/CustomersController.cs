using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{

    [Route("api/customers")]
    [ApiController]

    public class CustomersController: ControllerBase
    {

        private ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        /// <summary>
        /// It allows to obtain all the customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                customerService.GetAllCustomers()
            );
        }


        /// <summary>
        /// It allows to add a customer
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
            return Ok(
                customerService.Save(customer)
            );
        }

        /// <summary>
        /// It allows  to search for a customer by their corresponding Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                customerService.Get(id)
            );
        }

        /// <summary>
        /// It allows to obtain a customer by his user ID
        /// </summary>
        /// <returns></returns>
        [Route("searchByUserId/{id}")]
        [HttpGet]
        public ActionResult Get2(int id)
        {
            return Ok(
                customerService.GetCustomerByUserId(id)
            );
        }


         /// <summary>
        /// It allows to update a customer 
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public ActionResult Put([FromBody] Customer customer)
        {
            return Ok(
                customerService.Update(customer)
            );
        }

        /// <summary>
        /// It allows to add a subscription package
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}/addSubscription")]
        public ActionResult Get3(int id)
        {
            return Ok(
                customerService.ValidarSubscripcion(id)
            );
        }

        
    }
}