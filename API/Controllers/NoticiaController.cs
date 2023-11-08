
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechchallengeNoticias.Services;
using Webapiaspnet.Data;
using Webapiaspnet.Data.DTO;
using Webapiaspnet.Models;
namespace Webapiaspnet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class NoticiaController : ControllerBase
    {
        private readonly INoticiaService _noticiaService;
        public NoticiaController(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;    
        }

        // GET: api/<NoticiaController>
        [HttpGet]
        public IActionResult GetNoticias()
        {
            var noticias = new List<Noticia>();
            noticias = _noticiaService.GetAllNoticias();
            return Ok(noticias);
        }

        // GET api/<NoticiaController>/5
        [HttpGet("{id}")]
        public IActionResult NoticiaPorId(int id)
        {
            var noticia = _noticiaService.NoticiaPorId(id);

            if (ValidaNoticiaNull(noticia))
                return NotFound();

            return Ok(noticia);
        }

        // POST api/<NoticiaController>
        [HttpPost]
        public IActionResult AddNoticia([FromBody] CreateNoticiaDto noticiadto)
        {
            Noticia noticia = new Noticia
            {
                Titulo = noticiadto.Titulo,
                Descricao = noticiadto.Descricao,
                DataPublicacao = noticiadto.DataPublicacao,
                Autor = noticiadto.Autor
            };

            _noticiaService.AddNoticia(noticia);
            return CreatedAtAction(nameof(NoticiaPorId), new { id = noticia.Id }, noticia);
        }

        // PUT api/<NoticiaController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateNoticia(int id, [FromBody] UpdateNoticiaDto noticiadto)
        {
            var noticia = _noticiaService.NoticiaPorId(id);

            if (ValidaNoticiaNull(noticia))
                return NotFound();

            noticia.Titulo = noticiadto.Titulo;
            noticia.Descricao = noticiadto.Descricao;
            noticia.DataPublicacao = noticiadto.DataPublicacao;
            noticia.Autor = noticiadto.Autor;

            _noticiaService.UpdateNoticia();
           
            return NoContent();
        }

        // DELETE api/<NoticiaController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteNoticia(int id)
        {
            var noticia = _noticiaService.NoticiaPorId(id);

            if (ValidaNoticiaNull(noticia))
                return NotFound();
               
            _noticiaService.DeleteNoticia(noticia);
            
            return NoContent();
        }

        private bool ValidaNoticiaNull(Noticia noticia)
        {
            if (noticia == null)
                return true;

            return false;
        }

    }
}
