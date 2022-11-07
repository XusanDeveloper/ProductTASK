namespace ProductTASK.Data.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity FindByIdAsync(Guid? id);
        ValueTask<TEntity> AddAsync(TEntity entity);
        ValueTask<TEntity> RemoveAsync(TEntity entity);
        IQueryable<TEntity> FindAll();
        ValueTask<TEntity> UpdateAsync(TEntity entity);
    }
}
