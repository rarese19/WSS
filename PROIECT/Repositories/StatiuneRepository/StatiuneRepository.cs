using Microsoft.EntityFrameworkCore;
using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.StatiuneRepository
{
    public class StatiuneRepository: GenericRepository<Statiune>, IStatiuneRepository
    {
        public StatiuneRepository(Context context): base(context) { }

        public List<Statiune> StatiuneByRegiune (string regiune)
        {
            return _table.AsNoTracking().Where(x => x.Regiune == regiune).ToList();
        }

        public List<Statiune> StatiuniPartiiMagazine()
        {
            IQueryable<Statiune> query = _table;

            query = query.Include(p => p.Partii);

            query = query.Include(p => p.Magazine);

            return query.ToList();
        }

    }
}
