using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.AngajatRepository
{
    public interface IAngajatRepository: IGenericRepository<Angajat>
    {
        List<Angajat> AngajatiByMagazin(Guid id);

        
    }
}
