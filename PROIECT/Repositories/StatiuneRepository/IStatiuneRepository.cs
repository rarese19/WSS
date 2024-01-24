using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;

namespace WSS.Repositories.StatiuneRepository
{
    public interface IStatiuneRepository: IGenericRepository<Statiune>
    {
        List<Statiune> StatiuneByRegiune(string regiune);

        List<Statiune> StatiuniPartiiMagazine();

    }
}
