using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoedingClassLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpMVC_voeding
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        DatabaseContext jojohupake;
        public BarcodeController(DatabaseContext databaseContext)
        {
            jojohupake = databaseContext;
        }
        // GET: api/<BarcodeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Barcode barcode = new Barcode();
            barcode.Gewicht = 25;
            barcode.InputField = "wat tekst";
            jojohupake.Add(barcode);
            jojohupake.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/<BarcodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BarcodeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BarcodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BarcodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
