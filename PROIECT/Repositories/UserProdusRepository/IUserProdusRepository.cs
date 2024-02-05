using PROIECT.Models;
using PROIECT.Repositories.GenericRepository;
using WSS.Models.DTOs.ProdusDTOs;

namespace WSS.Repositories.UserProdusRepository
{
    public interface IUserProdusRepository: IGenericRepository<UserProdus>
    {
        List<ProdusDTO> GetProdusByUser(Guid id);
    }
}
