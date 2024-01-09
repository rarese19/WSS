using PROIECT.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace PROIECT.Models
{
    public class UserProdus: BaseEntity
    {
        [Required]
        public int Cantiate { get; set; }
        public User User { get; set; } = null!;
        public Guid UserID { get; set; }
        public Produs Produs { get; set; } = null!;
        public Guid ProdusID { get; set; }
    }
}
