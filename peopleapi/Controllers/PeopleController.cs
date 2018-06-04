using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using peopleapi.Models;
using peopleapi.Data;
using Microsoft.EntityFrameworkCore;

namespace peopleapi.Controllers
{
    /// <summary>
    /// This class is the main API class that connects to a database to send back information on People.
    /// </summary>
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {

        private readonly peopleAPIContext _context;

        public PeopleController(peopleAPIContext context) {
            // get the database context
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _context.Person.OrderBy(x => x.LastName).OrderBy(y => y.FirstName).ToListAsync());
        }

        // GET api/values/GUID-TO-PERSON
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
           return Json(await _context.Person.Where(z => z.PersonId == id).SingleOrDefaultAsync());
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
