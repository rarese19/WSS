using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.MagazinProdusRepository
{
    public class MagazinProdusRepository: GenericRepository<MagazinProdus>, IMagazinProdusRepository
    {
        public MagazinProdusRepository(Context context) : base(context) { }
    }
}
