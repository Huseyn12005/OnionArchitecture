using Application.Repositories.Commons;
using Domain.Entities.Abratcts;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories.Commons;

public class GenericReadRepository<T> : GenericRepository<T>, IGenericReadRepository<T>
    where T : BaseEntity, new()
{
    public GenericReadRepository(AppDbContext context) : base(context) { }

    public async Task<IQueryable<T>> GetAllAsync()
    {
        return _entity;
    }

    public async Task<T?> GetAsync(int id)
    {
        return await _entity.FirstOrDefaultAsync(x => x.Id == id);
    }
}
