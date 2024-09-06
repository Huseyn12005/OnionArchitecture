using Application.Repositories.Writes;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Commons;

namespace Persistence.Repositories.Writes;

public class UserWriteRepository : GenericWriteRepository<User>, IUserWriteRepository
{
    public UserWriteRepository(AppDbContext context) : base(context)
    {
    }
}
