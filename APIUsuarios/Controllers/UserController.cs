using APIUsuarios.Models;
using APIUsuarios.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace APIUsuarios.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("Usuario")]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;


        public UserController(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CreateUserDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            usuario.ChaveValidacao = ""; //Adicionar a chave de validação
            try
            {
                IdentityResult result = await _userManager.CreateAsync(usuario, dto.PassWord);

                if (result.Succeeded)
                    return Ok("Usuário cadastrado com Sucesso!");

                // Se falhar, retorna os erros de validação
                return BadRequest(result.Errors);
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException("Falha ao cadastrar usuário", ex);
            }
        }

    }
}
