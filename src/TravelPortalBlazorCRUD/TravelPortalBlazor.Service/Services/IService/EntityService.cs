using Microsoft.EntityFrameworkCore;
using TravelPortalBlazor.Core.Context;
using TravelPortalBlazor.Core.Entity.Interface;


namespace TravelPortalBlazor.Service.Services.IService
{
    public class EntityService<TEntity, TKey> : IEntityService<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        protected DataContext _ctx;
        protected DbSet<TEntity> _dbSet;
        public EntityService(DataContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<TEntity>();
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _ctx.Set<TEntity>().ToListAsync();

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _ctx.Set<TEntity>().AddAsync(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<bool> DeleteAsync(TKey id)
        {
            _ctx.Set<TEntity>().Remove(await _ctx.Set<TEntity>().FindAsync(id));
            await _ctx.SaveChangesAsync();
            return true;
        }
        public virtual async Task<TEntity> UpdateAsync(TKey id, TEntity entity)
        {
            _ctx.Set<TEntity>().Update(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _ctx.Set<TEntity>().FindAsync(id);
        }
    }

}
