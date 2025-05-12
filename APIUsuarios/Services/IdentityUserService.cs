using APIUsuarios.Models;
using APIUsuarios.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace APIUsuarios.Services
{
    public class IdentityUserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;

        public IdentityUserService(UserManager<Usuario> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task CreateUser(CreateUserDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            usuario.ChaveValidacao = ""; //Adicionar a chave de validação
            try
            {
                IdentityResult result = await _userManager.CreateAsync(usuario, dto.PassWord);

            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("Falha ao cadastrar usuário", ex);
            }
        }
    }

}
