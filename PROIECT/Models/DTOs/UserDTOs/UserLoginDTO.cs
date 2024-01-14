using System.ComponentModel.DataAnnotations;

namespace WSS.Models.DTOs.UserDTOs
{
    public class UserLoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
