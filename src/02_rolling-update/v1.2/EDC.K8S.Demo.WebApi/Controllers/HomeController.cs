using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EDC.K8S.Demo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/home
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {
                "Hello, welcome to EDC's demo. Version: 1.2"
            };
        }

        // GET api/home/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Hello, Your parameter is {id}.";
        }

        // POST api/home
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/home/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
