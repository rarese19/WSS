using Microsoft.EntityFrameworkCore;
using PROIECT.Data;
using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;
using WSS.Models.DTOs.AngajatDTOs;

namespace WSS.Repositories.AngajatRepository
{
    public class AngajatRepository : GenericRepository<Angajat>, IAngajatRepository
    {
        public AngajatRepository(Context context) : base(context) { }

        public List<Angajat> AngajatiByMagazin(Guid id)
        {
            return _table.AsNoTracking().Where(x => x.MagazinID == id).ToList();
        }
    }
}
