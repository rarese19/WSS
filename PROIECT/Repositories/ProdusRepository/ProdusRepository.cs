using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.ProdusRepository
{
    public class ProdusRepository: GenericRepository<Produs>, IProdusRepository
    {
        public ProdusRepository(Context context) : base(context) { }
    }
}
