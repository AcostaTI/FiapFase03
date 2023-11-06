using System.ComponentModel.DataAnnotations;

namespace Webapiaspnet.Data.DTO
{
    public class UpdateNoticiaDto
    {
        [Required(ErrorMessage = "O Titulo da Noticia é obrigatório")]
        [StringLength(100, ErrorMessage = "O titulo deve ter menos de 100 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A descricao da noticia é obrigatória")]
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage = "O Autor da noticia é obrigatório")]
        public string Autor { get; set; }
    }
}
