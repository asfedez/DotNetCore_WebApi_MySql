using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MySqlApi.Models;


namespace MySqlApi.Controllers
{

    [Route("api/[controller]")]
    public class TodoController : Controller
    {

        private readonly TodoDBContext _context;

        public TodoController(TodoDBContext context)
        {
            _context = context;
        }



        // esta es la forma de obtener datos desde .NET core a mysql
        [HttpGet]
        public IEnumerable<item> Get()
        {
            return _context.item.OrderBy(itm => itm.id).ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<item> Get(int id)
        {
            return _context.item.FirstOrDefault(itm => itm.id == id);
        }

        [HttpPost]
        public ActionResult<item> Create([FromBody] item item)
        {
            
            _context.Add(item);
            _context.SaveChanges();

            // return CreatedAtRoute("GetItem", new { id = item.id.ToString() }, item);
            return item;
        }

         [HttpPut("{id}")]
        public ActionResult<item> Update(int id, [FromBody] item item)
        {
           
            var itemContext = _context.item.FirstOrDefault(itm => itm.id == id);
            

            if (itemContext != null)
            {
                itemContext.description = item.description;
                itemContext.ischeck = item.ischeck;
                _context.item.Update(itemContext);
                _context.SaveChanges();
            }
            else{
                //itemContext.description="no funciona";
                return BadRequest();
            }

            return itemContext;
        }


        [HttpDelete("{id}")]
        public ActionResult<item> Delete(int id)
        {
            var itemContext = _context.item.FirstOrDefault(itm => itm.id == id);
                    

            if (itemContext != null)
            {
                _context.item.Remove(itemContext);
                _context.SaveChanges();
            }
            else{
                //itemContext.description="no funciona";
                return BadRequest();
            }

            return itemContext;
        }

    }

}