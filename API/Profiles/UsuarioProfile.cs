using AutoMapper;
using TechchallengeNoticias.Data.DTO;
using TechchallengeNoticias.Models;

namespace TechchallengeNoticias.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
