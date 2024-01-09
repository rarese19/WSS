using PROIECT.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace PROIECT.Models
{
    public class Produs: BaseEntity
    {
        public string Nume { get; set; } = null!;
        public int Pret {  get; set; } = 0!;
        public int Stoc { get; set; }
        public string Brand { get; set; } = null!;
        public ICollection<MagazinProdus>? MagazinProduse { get; set; }
        public ICollection<UserProdus>? UserProduse { get; set; }

    }
}
