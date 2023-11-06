using Webapiaspnet.Data;
using Webapiaspnet.Models;

namespace TechchallengeNoticias.Repositories
{
    public class NoticiaRepository : INoticiaRepository
    {
        private readonly WebApiContext _context;
        public NoticiaRepository(WebApiContext webApiContext) {
            _context = webApiContext;
        }
        public void AddNoticia(Noticia noticia)
        {
            _context.Noticia.Add(noticia);
            _context.SaveChanges();
        }

        public void DeleteNoticia(Noticia noticia)
        {
            _context.Remove(noticia);
            _context.SaveChanges();
        }

        public List<Noticia> GetAllNoticias()
        {
           return _context.Noticia.ToList();

        }

        public Noticia NoticiaPorId(int id)
        {
            Noticia noticia = new Noticia();
            noticia = _context.Noticia.FirstOrDefault(noticia => noticia.Id == id);
            return noticia;
        }

        public void UpdateNoticia()
        {
            _context.SaveChanges();
        }
    }
}
