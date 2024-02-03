using AutoMapper;
using PROIECT.Models;
using WSS.Models.DTOs.MagazinProdusDTOs;
using WSS.Repositories.MagazinProdusRepository;

namespace WSS.Services.MagazinProdusServices
{
    public class MagazinProdusService: IMagazinProdusService
    {
        private readonly IMagazinProdusRepository _magazinProdusRepository;
        private readonly IMapper _mapper;

        public MagazinProdusService(IMagazinProdusRepository magazinProdusRepository, IMapper mapper)
        {
            _magazinProdusRepository = magazinProdusRepository;
            _mapper = mapper;
        }


        public async Task Create(MagazinProdusDTO magazinprodus)
        {
            await _magazinProdusRepository.CreateAsync(_mapper.Map<MagazinProdus>(magazinprodus));
            await _magazinProdusRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _magazinProdusRepository.DeleteById(id);
            _magazinProdusRepository.Save();
        }
    }
}
