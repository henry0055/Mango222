using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace Mango.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class ActorController : Controller
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(
                _actorService.GetAll()
                );
        }




        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(
                _actorService.Get(id)
             );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Actor Model)
        {
            return Json(
                _actorService.Add(Model)
             );

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Actor model)
        {
            return Json(
               _actorService.Add(model)
            );
        }

        // DELETE api/values/5
        [HttpPost("{id}")]
        public IActionResult Delete(int id)
        {
            return Json(
              _actorService.Delete(id)
           );
        }

        [HttpGet("{cantidad}")]
        public IActionResult GetRandomActor(int cantidad)
        {
            return Json(
                _actorService.GetRandomActor(cantidad)
             );
        }

    }



}
