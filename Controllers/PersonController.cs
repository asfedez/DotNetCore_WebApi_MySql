using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MySqlApi.Models;


namespace MySqlApi.Controllers
{

    [Route("api/[controller]")]
    public class PersonController : Controller
    {

        private readonly TutorialContext _context;

        public PersonController(TutorialContext context)
        {
            _context = context;
        }



        // esta es la forma de obtener datos desde .NET core a mysql
        [HttpGet]
        public IEnumerable<person> Get()
        {
            return _context.person.ToList();
        }
    }

}