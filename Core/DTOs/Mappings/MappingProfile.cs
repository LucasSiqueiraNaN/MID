using AutoMapper;
using Core.Dominio;

namespace Core.DTOs.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Pessoa, PessoaDTO>().ReverseMap();
        }
    }
}
