using Application.Repositories.Writes;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Commons;

namespace Persistence.Repositories.Writes;

public class CarWriteRepository : GenericWriteRepository<Car>, ICarWriteRepository
{
    public CarWriteRepository(AppDbContext context) : base(context)
    {
    }
}
