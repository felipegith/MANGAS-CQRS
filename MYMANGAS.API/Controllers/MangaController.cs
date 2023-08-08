using Microsoft.AspNetCore.Mvc;
using MYMANGAS.APPLICATION.Models;
using MYMANGAS.APPLICATION.Services.Contracts;
using MYMANGAS.DOMAIN.Commands;

namespace MYMANGAS.API.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class MangaController : ControllerBase
    {
        private readonly IMangaService _services;

        public MangaController(IMangaService services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("create-manga")]
        public IActionResult Create([FromBody] MangaViewModel viewModel)
        {
            var createManga =  _services.Create(viewModel);

            return Created("get-name", createManga);
            
            
        }

        [HttpPatch]
        [Route("update-name")]
        public IActionResult Update([FromBody] MangaViewModel viewModel)
        {
            var updateManga = _services.UpdateName(viewModel);

            return Ok(updateManga);
        }

        [HttpPatch]
        [Route("update-read")]
        public IActionResult UpdateRead([FromBody] MangaViewModel viewModel)
        {
            var updateManga = _services.UpdateRead(viewModel);

            return Ok(updateManga);
        }

        [HttpDelete]
        [Route("delete-manga")]
        public IActionResult Delete([FromQuery]MangaViewModel viewModel)
        {
            var deleteManga = _services.Delete(viewModel);

            return Ok(deleteManga);
        }

        [HttpGet]
        [Route("get-manga")]
        public IActionResult GetById([FromQuery] MangaViewModel viewModel)
        {
            var getManga = _services.GetById(viewModel);

            return Ok(getManga);
        }
        [HttpGet]
        [Route("get-mangas")]
        public IActionResult GetAll(string user)
        {
            var getMangas = _services.GetAll(user);

            if(getMangas is null)
                return NotFound(getMangas);

            return Ok(getMangas);
        }

    }
}
