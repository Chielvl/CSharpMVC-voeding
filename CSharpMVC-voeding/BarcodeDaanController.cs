using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VoedingClassLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpMVC_voeding
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeDaanController : ControllerBase
    {



        DatabaseContext data;

        public BarcodeDaanController(DatabaseContext abc)
        {
            data = abc;
        }


        // GET: api/<BarcodeDaanController>
        [HttpGet]

        public IEnumerable<Barcode> Get()
        {
            return data.barcodes;
        }

        // GET api/<BarcodeDaanController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BarcodeDaanController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BarcodeDaanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BarcodeDaanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
