using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIUsuarios.Models.Context
{

    public class UsuarioDbContext :IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> opts): base(opts) 
        {


        }
    }
}
