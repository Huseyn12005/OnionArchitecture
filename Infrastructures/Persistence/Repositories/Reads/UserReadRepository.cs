using Application.Repositories.Reads;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Commons;

namespace Persistence.Repositories.Reads;

public class UserReadRepository : GenericReadRepository<User>, IUserReadRepository
{
    public UserReadRepository(AppDbContext context) : base(context)
    {
    }
}
