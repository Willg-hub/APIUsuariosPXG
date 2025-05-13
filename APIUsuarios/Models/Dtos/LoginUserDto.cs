using System.ComponentModel.DataAnnotations;

namespace APIUsuarios.Models.Dtos

{
    public class LoginUserDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string IP { get; set; }

    }
}
