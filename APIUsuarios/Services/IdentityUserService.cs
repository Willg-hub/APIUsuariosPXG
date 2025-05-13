using APIUsuarios.Models;
using APIUsuarios.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace APIUsuarios.Services
{
    public class IdentityUserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public IdentityUserService(UserManager<Usuario> userManager, IMapper mapper, SignInManager<Usuario> signInManager )
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        public async Task CreateUser(CreateUserDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            usuario.UserName = dto.Email;
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
        public async Task Login(LoginUserDto dto)
        {
           var result = await _signInManager.PasswordSignInAsync(dto.Email, dto.Password, false, false);
            if (!result.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado");
            }

        }
    }

}
