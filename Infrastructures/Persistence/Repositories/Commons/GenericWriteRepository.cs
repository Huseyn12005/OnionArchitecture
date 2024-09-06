using Application.Repositories.Commons;
using Domain.Entities.Abratcts;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories.Commons;

public class GenericWriteRepository<T> : GenericRepository<T>, IGenericWriteRepository<T>
    where T : BaseEntity, new()
{
    public GenericWriteRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _entity.Update(entity);
        return entity;
    }

    public async Task AddAsync(T entity)
    {
        await _entity.AddAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _entity.FirstOrDefaultAsync(x => x.Id == id);
        if (entity is not null)
            _entity.Remove(entity);
    }
}
