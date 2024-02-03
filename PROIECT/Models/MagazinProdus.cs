using PROIECT.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace PROIECT.Models
{
    public class MagazinProdus: BaseEntity
    {
        public string Cantitate { get; set; }
        public Magazin Magazin { get; set; } = null!;
        public Guid MagazinID { get; set; }
        public Produs Produs { get; set; } = null!;
        public Guid ProdusID { get; set; }
    }
}
