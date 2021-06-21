using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.Controllers
{
    //just look at this crazy attribute routing. we do not only add routes as attributes to actions, but also kind of a route template to the controller itself. and it has placeholders, crazy
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        public class Car
        {
            public string Make { get; set; }
        }
        [Route("za")]
        public IActionResult SomeApiMethod()
        {
            return Ok("aaa");
        }
        
        [HttpGet("contacts")]
        public IActionResult GetContacts()
        {
            return Ok(new string[]{"vasya", "petya"});
        }
        
        [HttpPost("contacts")]
        public IActionResult WriteContacts([FromBody] Car car)
        {
            return Ok(car.Make);
        }
    }
}
