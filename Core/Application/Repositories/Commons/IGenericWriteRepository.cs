using Domain.Entities.Abratcts;

namespace Application.Repositories.Commons;

public interface IGenericWriteRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    Task AddAsync(T entity);
    Task DeleteAsync(int id);
    Task<T> UpdateAsync(T entity);
}
