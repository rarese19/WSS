using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.MagazinProdusRepository
{
    public class MagazinProdusRepository: GenericRepository<MagazinProdus>, IMagazinProdusRepository
    {
        public MagazinProdusRepository(Context context) : base(context) { }

        public List<List<string>> GetProdusePerMagazinBrand()
        {
            var grupare = (from mp in _context.MagazinProduse
                           join p in _context.Produse on mp.ProdusID equals p.Id
                           join m in _context.Magazine on mp.MagazinID equals m.Id
                           group new { mp, p } by new { m.Id, p.Brand, mp.Cantitate } into g
                           select new
                           {
                               MagazinID = g.Key.Id,
                               Brand = g.Key.Brand,
                               NumarProduse = g.Key.Cantitate
                           }).ToList();

            List<List<string>> rezultate = new List<List<string>>();

            foreach (var grup in grupare)
            {
                List<string> detaliiMagazin = new List<string>
            {
                $"In magazinul cu id {grup.MagazinID} avem:",
                $"{grup.NumarProduse} produse de la brandul {grup.Brand}"
            };

                rezultate.Add(detaliiMagazin);
            }

            return rezultate;
        }
    }
}
