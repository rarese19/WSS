using AutoMapper;
using PROIECT.Models;
using WSS.Models.DTOs.ProdusDTOs;
using WSS.Repositories.ProdusRepository;

namespace WSS.Services.ProdusServices
{
    public class ProdusServices: IProdusServices
    {
        private readonly IProdusRepository _produsRepository;
        private readonly IMapper _mapper;

        public ProdusServices(IProdusRepository produsRepository, IMapper mapper)
        {
            _produsRepository = produsRepository;
            _mapper = mapper;
        }

        public bool Delete(Guid produsId) 
        { 
            _produsRepository.DeleteById(produsId);
            _produsRepository.Save();
            return true;
        }

        public async Task<List<ProdusDTO>> GetAllProduse()
        {
            return _mapper.Map<List<ProdusDTO>>(await _produsRepository.GetAllAsync());
        }

        public async Task<List<Produs>> GetAllProduseInfo()
        {
            return await _produsRepository.GetAllAsync();
        }

        public ProdusDTO GetProdusById(Guid id)
        {
            return _mapper.Map<ProdusDTO>(_produsRepository.FindById(id));
        }

        public async Task ProdusCreate(ProdusDTO produs)
        {
            await _produsRepository.CreateAsync(_mapper.Map<Produs>(produs));
            await _produsRepository.SaveAsync();
        }

        public void Update(ProdusUpdateDTO produs)
        {
            _produsRepository.Update(_mapper.Map<Produs>(produs));
            _produsRepository.Save();
        }
    }
}
