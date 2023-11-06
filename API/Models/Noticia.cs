using System.ComponentModel.DataAnnotations;

namespace Webapiaspnet.Models
{
    public class Noticia
    {
        [Required]
        [Key]
        public int Id { get; set; }  
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Autor { get; set; }
    }
}
