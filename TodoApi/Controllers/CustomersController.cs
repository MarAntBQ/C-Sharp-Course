using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        /*[Route("/")]*/
        public dynamic customersList()
        {
            Console.WriteLine("Testing Get Endpoint my MarAntBQ.dev");
            ArrayList customers = new ArrayList();
            customers.Add(new { id = 1, name = "Marco Antonio" });
            customers.Add(new { id = 2, name = "Ana Verónica" });
            return customers;
        }
        [HttpPost]
        public dynamic createCustomer()
        {
            // Return an empty object
            return new { };
        }
    }
}
