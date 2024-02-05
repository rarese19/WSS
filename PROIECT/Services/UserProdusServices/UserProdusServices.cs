using AutoMapper;
using PROIECT.Models;
using WSS.Models.DTOs.ProdusDTOs;
using WSS.Models.DTOs.UserProdusDTOs;
using WSS.Repositories.UserProdusRepository;

namespace WSS.Services.UserProdusServices
{
    public class UserProdusServices: IUserProdusServices
    {
        private readonly IUserProdusRepository _userProdusRepository;
        private readonly IMapper _mapper;

        public UserProdusServices(IUserProdusRepository userProdusRepository, IMapper mapper)
        {
            _userProdusRepository = userProdusRepository;
            _mapper = mapper;
        }


        public async Task Create(UserProdusDTO magazinprodus)
        {
            await _userProdusRepository.CreateAsync(_mapper.Map<UserProdus>(magazinprodus));
            await _userProdusRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _userProdusRepository.DeleteById(id);
            _userProdusRepository.Save();
        }

        public List<ProdusDTO> GetProdusByUser(Guid id)
        {
            return _userProdusRepository.GetProdusByUser(id);
        }
    }
}
