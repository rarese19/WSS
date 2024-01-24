using PROIECT.Models.Base;

namespace PROIECT.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity: BaseEntity
    {
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();

        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        TEntity FindById(Guid id);
        Task<TEntity> FindByIdAsync(Guid id);

        void Delete(TEntity entity);
        bool DeleteById(Guid id);
        void DeleteRange(IEnumerable<TEntity> entitites);

        bool Save();
        Task<bool> SaveAsync();
    }

}
