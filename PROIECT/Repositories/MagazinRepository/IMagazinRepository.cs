using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.MagazinRepository
{
    public interface IMagazinRepository: IGenericRepository<Magazin>
    {
        List<Magazin> MagazineDinRegiuni(string regiune);
        public List<Magazin> MagazinCuAngajati();
    }
}
