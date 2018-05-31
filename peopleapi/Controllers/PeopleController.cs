using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using peopleapi.Models;

namespace peopleapi.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            List<Person> people = new List<Person>();
            Person p = new Person();
            p.FirstName = "Richard";
            p.LastName = "Cranium";
            p.City = "Annapolis";
            p.State = "Maryland";
            p.ZIP = "21403";
            p.Email = "Richard.Cranium@me.com";
            people.Add(p);
            p = new Person();
            p.FirstName = "Peter";
            p.LastName = "O'Toole";
            p.City = "Crofton";
            p.State = "Maryland";
            p.ZIP = "21114";
            p.Email = "Peter.OToole@me.com";
            people.Add(p);
            return people;
        }

        // GET api/values/GUID-TO-PERSON
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Person value)
        {
        }

        // PUT api/values/GUID-TO-PERSON
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Person value)
        {
        }

        // DELETE api/values/GUID-TO-PERSON
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
