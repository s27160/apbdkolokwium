namespace kolokwium.Repositories;

public interface IDataRepository<TEntity>
{
    TEntity GetById(int id);
    IQueryable<TEntity> Query();
    void Add(TEntity entity);
}