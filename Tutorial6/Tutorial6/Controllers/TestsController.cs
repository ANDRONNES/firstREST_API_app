using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tutorial6.Models;

namespace Tutorial6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var tests = DataBase.Tests;
            return Ok(tests);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(/*[FromRoute]*/int id)
        {
            var tests = DataBase.Tests.FirstOrDefault(x => x.Id == id);
            return Ok(tests);
        }
        
        //POST api/tests { "id": 4, "name" : "Test4" }
        [HttpPost]
        public IActionResult Add(Test test)
        {
            DataBase.Tests.Add(test);
            return Created();
        }
    }
}
