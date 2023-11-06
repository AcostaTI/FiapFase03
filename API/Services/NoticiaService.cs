using TechchallengeNoticias.Repositories;
using Webapiaspnet.Models;

namespace TechchallengeNoticias.Services
{
    public class NoticiaService : INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;
        public NoticiaService(INoticiaRepository noticiaRepository) 
        {
            _noticiaRepository = noticiaRepository;
        }
        public void AddNoticia(Noticia noticia)
        {
            _noticiaRepository.AddNoticia(noticia);    
        }

        public void DeleteNoticia(Noticia noticia)
        {
            _noticiaRepository.DeleteNoticia(noticia);
        }

        public List<Noticia> GetAllNoticias()
        {
            return _noticiaRepository.GetAllNoticias();
        }

        public Noticia NoticiaPorId(int id)
        {
            return _noticiaRepository.NoticiaPorId(id);
        }

        public void UpdateNoticia()
        {
            _noticiaRepository.UpdateNoticia();
        }
    }
}
