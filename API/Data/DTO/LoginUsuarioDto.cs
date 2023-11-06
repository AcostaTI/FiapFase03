using System.ComponentModel.DataAnnotations;

namespace TechchallengeNoticias.Data.DTO
{
    public class LoginUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
