using APIUsuarios.Models.Dtos;
using AutoMapper;

namespace APIUsuarios.Models.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, Usuario>();
        }
    }
}
