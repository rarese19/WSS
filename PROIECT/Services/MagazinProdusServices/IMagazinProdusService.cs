using WSS.Models.DTOs.MagazinProdusDTOs;

namespace WSS.Services.MagazinProdusServices
{
    public interface IMagazinProdusService
    {
        Task Create(MagazinProdusDTO test);
        void Delete(Guid id);
    }
}
