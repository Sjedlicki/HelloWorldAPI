using System.Collections.Generic;
using System.Threading.Tasks;
using CodeChallenge.Domain.Abstract;
using CodeChallenge.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeChallenge.Controllers
{
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        //private Data _data;
        private IData _data;
        // GET: api/<controller>
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetData([FromBody] int id, string text)
        {
            var HelloWorld = await _data.GetData();

            return Ok(HelloWorld);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Data value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { text = value.Text }, value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
