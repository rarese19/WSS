using WSS.Models.DTOs.ProdusDTOs;
using WSS.Models.DTOs.UserProdusDTOs;

namespace WSS.Services.UserProdusServices
{
    public interface IUserProdusServices
    {
        Task Create(UserProdusDTO test);
        void Delete(Guid id);

        List<ProdusDTO> GetProdusByUser(Guid id);
    }
}
