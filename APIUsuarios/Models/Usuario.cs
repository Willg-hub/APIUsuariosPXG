using Microsoft.AspNetCore.Identity;

namespace APIUsuarios.Models
{
    public class Usuario : IdentityUser
    {
        public string Ip { get; set; }
        
        public string ChaveValidacao { get; set; }

        public string NomeUsuario { get; set; }

        public Usuario() : base()
        {
            
        }
    }
}
