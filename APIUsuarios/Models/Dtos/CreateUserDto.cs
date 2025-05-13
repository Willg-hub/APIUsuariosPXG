using System.ComponentModel.DataAnnotations;

namespace APIUsuarios.Models.Dtos
{
    public class CreateUserDto
    {

        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Ip { get; set; }

        [Required]
        public string NomeUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
