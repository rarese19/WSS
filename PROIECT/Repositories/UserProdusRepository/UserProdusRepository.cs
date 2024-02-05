using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;
using WSS.Models.DTOs.ProdusDTOs;

namespace WSS.Repositories.UserProdusRepository
{
    public class UserProdusRepository: GenericRepository<UserProdus>, IUserProdusRepository
    {
        public UserProdusRepository(Context context): base(context) { }

        public List<ProdusDTO> GetProdusByUser(Guid userId)
        {
            var produse = from up in _context.UserProduse // Folosește _context aici
                          join p in _context.Produse on up.ProdusID equals p.Id
                          where up.UserID == userId
                          select new ProdusDTO
                          {
                              Nume = p.Nume,
                              Pret = p.Pret
                          };

            return produse.ToList();
        }
    }
}
