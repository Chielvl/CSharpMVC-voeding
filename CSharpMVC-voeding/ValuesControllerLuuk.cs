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
    public class ValuesControllerLuuk : ControllerBase
    {
        DatabaseContext db;
        public ValuesControllerLuuk(DatabaseContext _db)
        {
            db = _db;
        }

        // https://localhost:44310/api/ValuesControllerLuuk/createNew/0/code/21
        [HttpGet("createNew/{_inputField}/{_gewicht}")]
        public IEnumerable<Barcode> CreateNew(String _inputField, double _gewicht)
        {
            Barcode bc = new Barcode();
            bc.InputField = _inputField;
            bc.Gewicht = _gewicht;
            db.Add(bc);
            db.SaveChanges();
            return db.barcodes;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
