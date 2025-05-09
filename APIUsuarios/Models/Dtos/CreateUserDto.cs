using System.ComponentModel.DataAnnotations;

namespace APIUsuarios.Models.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Ip { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
