using Microsoft.EntityFrameworkCore;
using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.MagazinRepository
{
    public class MagazinRepository : GenericRepository<Magazin>, IMagazinRepository
    {
        public MagazinRepository(Context context) : base(context) { }

        public List<Magazin> MagazineDinRegiuni(string regiune)
        {
            return _table.Include(ob => ob.Statiune)
                    .Where(ob => ob.Statiune.Regiune == regiune) .ToList();

        }

        public List<Magazin> MagazinCuAngajati()
        {
            IQueryable<Magazin> query = _table;

            query = query.Include(m => m.Angajati);

            return query.ToList();
        }
    }
}
