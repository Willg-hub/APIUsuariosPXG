﻿using APIUsuarios.Models;
using APIUsuarios.Models.Dtos;
using APIUsuarios.Services;
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
        private readonly IdentityUserService _identityUserService;


        public UserController(IdentityUserService identityUserService)
        {
            _identityUserService = identityUserService;
        }

        [HttpPost("Cadastro")]
        public async Task<IActionResult> CadastrarUsuario(CreateUserDto dto)
        {

                await _identityUserService.CreateUser(dto);
                return Ok("Usuário cadastrado com Sucesso!");

        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginUserDto dto)
        {
            await _identityUserService.Login(dto);
            return Ok("Usuário autenticado");
        }
    }
}
