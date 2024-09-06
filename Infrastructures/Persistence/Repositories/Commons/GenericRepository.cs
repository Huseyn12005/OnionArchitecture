using Application.Repositories.Commons;
using Domain.Entities.Abratcts;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories.Commons;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    protected AppDbContext _context;
    protected DbSet<T> _entity;
    public GenericRepository(AppDbContext context)
    {
        this._context = context;
        _entity = context.Set<T>();
    }

    public async Task SaveAllChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
