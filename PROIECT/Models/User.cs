using PROIECT.Models.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PROIECT.Models
{
    public class User: IdentityUser<Guid>
    {
        [Required]
        public string Nume { get; set; }
        public string? Prenume { get; set; }
        public string? CNP { get; set; }
        [Required]
        public ICollection<UserProdus> UserProduse { get; set; } = null!;

    }
}
