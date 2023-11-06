using Microsoft.AspNetCore.Mvc;
using Webapiaspnet.Data.DTO;
using Webapiaspnet.Models;

namespace TechchallengeNoticias.Services
{
    public interface INoticiaService
    {
        void AddNoticia(Noticia noticia);

        Noticia NoticiaPorId(int id);

        void UpdateNoticia();

        void DeleteNoticia(Noticia noticia);

        List<Noticia> GetAllNoticias();
    }
}
