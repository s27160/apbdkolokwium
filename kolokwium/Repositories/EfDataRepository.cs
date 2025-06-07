using Microsoft.EntityFrameworkCore;
using System.Linq;
using kolokwium.Models;

namespace kolokwium.Repositories;

public class EfDataRepository<TEntity> : IDataRepository<TEntity>
    where TEntity : class
{
    private readonly ApplicationDbContext _ctx;
    public EfDataRepository(ApplicationDbContext ctx) => _ctx = ctx;

    public TEntity GetById(int id) 
        => _ctx.Set<TEntity>().Find(id);

    public IQueryable<TEntity> Query() 
        => _ctx.Set<TEntity>();

    public void Add(TEntity entity)
    {
        _ctx.Set<TEntity>().Add(entity);
        _ctx.SaveChanges();
    }
}