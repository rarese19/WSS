using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.PartieRepository
{
    public interface IPartieRepository: IGenericRepository<Partie>
    {
        List<Partie> PartiiDinStatiune(Guid id);
    }
}
