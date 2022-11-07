using ProductTASK.Data.Context;
using ProductTASK.Data.Repositories.Interfaces;

namespace ProductTASK.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask<TEntity> AddAsync(TEntity entity)
        {
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
            
            return entity;
        }

        public TEntity FindByIdAsync(Guid? id) => dbContext.Set<TEntity>().Find(id);

        public IQueryable<TEntity> FindAll() => dbContext.Set<TEntity>();

        public async ValueTask<TEntity> RemoveAsync(TEntity entity)
        {
            dbContext.Remove(entity);
            await dbContext.SaveChangesAsync();

            return entity;
        }

        public async ValueTask<TEntity> UpdateAsync(TEntity entity)
        {
            dbContext.Update(entity);
            await dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
