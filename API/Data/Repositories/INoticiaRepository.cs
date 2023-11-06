using Webapiaspnet.Models;

namespace TechchallengeNoticias.Repositories
{
    public interface INoticiaRepository
    {
        void AddNoticia(Noticia noticia);

        Noticia NoticiaPorId(int id);

        void UpdateNoticia();

        void DeleteNoticia(Noticia noticia);

        List<Noticia> GetAllNoticias();
    }
}
