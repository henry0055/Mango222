using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Model;
using static Services.MediaService;

namespace Mango.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class MediaController : Controller
    {
        private readonly IMediaService  _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(
                _mediaService.GetAll()
                );
        }




        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Json(
                _mediaService.Get(id)
             );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Media Model)
        {
            return Json(
                _mediaService.Add(Model)
             );

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Media model)
        {
            return Json(
               _mediaService.Add(model)
            );
        }

        // DELETE api/values/5
        [HttpPost("{id}")]
        public IActionResult Delete(int id)
        {
            return Json(
              _mediaService.Delete(id)
           );
        }

        [HttpGet("{cantidad}")]
        public IActionResult GetRandom(int cantidad)
        {
            return Json(
                _mediaService.GetRandom(cantidad)
             );
        }

        [HttpPost]
        public IActionResult Calificar(Media model)
        {
            return Json(
                _mediaService.Calificar(model.Id , model.Acumulado)
                );
        }

    }
}