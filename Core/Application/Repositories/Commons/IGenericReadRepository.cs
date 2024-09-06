using Domain.Entities.Abratcts;

namespace Application.Repositories.Commons;

public interface IGenericReadRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    Task<T?> GetAsync(int id);
    Task<IQueryable<T>> GetAllAsync();
}
