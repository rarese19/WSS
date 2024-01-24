using Microsoft.EntityFrameworkCore;
using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.PartieRepository
{
    public class PartieRepository: GenericRepository<Partie>, IPartieRepository
    {
        public PartieRepository(Context context) : base(context) { }

        public List<Partie> PartiiDinStatiune(Guid Id)
        {
            return _table.AsNoTracking().Where(x => x.StatiuneID == Id).ToList();
        }
    }
}
