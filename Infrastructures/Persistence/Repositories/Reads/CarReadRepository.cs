using Application.Repositories.Reads;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Commons;

namespace Persistence.Repositories.Reads;

public class CarReadRepository : GenericReadRepository<Car>, ICarReadrepository
{
    public CarReadRepository(AppDbContext context) : base(context)
    {
    }
}
