using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        List<Beer> Beers = new List<Beer>()
        {
            new Beer(){ ID = 1, Name = "Corona"},
            new Beer(){ ID = 2, Name = "Indio"},
            new Beer(){ ID = 3, Name = "Hainekent"},
        };

        [HttpGet]
        public ActionResult<Beer> Get(int ID)
        {
            var beer = Beers.Where(d => d.ID == ID).FirstOrDefault();
            if (beer == null)
            {
                return NotFound();
            }
            else
            {
                return beer;
            }
        }
    }


    public class Beer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
