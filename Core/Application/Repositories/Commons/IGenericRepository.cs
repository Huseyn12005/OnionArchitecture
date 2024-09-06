using Domain.Entities.Abratcts;

namespace Application.Repositories.Commons;

public interface IGenericRepository<T> where T: BaseEntity, new()
{
    Task SaveAllChangesAsync();
}
