using TravelPortalBlazor.Core.Entity.Interface;

namespace TravelPortalBlazor.Service.Services.IService
{
    public interface IEntityService<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TKey id, TEntity entity);
        Task<bool> DeleteAsync(TKey id);
    }

}
