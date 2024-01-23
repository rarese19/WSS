using PROIECT.Models.Base;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PROIECT.Models
{
    public class User: IdentityUser<Guid>
    {
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        [Required]
        public ICollection<UserProdus> UserProduse { get; set; } = null!;

    }
}
