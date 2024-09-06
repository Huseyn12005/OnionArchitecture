using Application.Repositories.Writes;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Commons;

namespace Persistence.Repositories.Writes;

public class GalleryWriteRepository : GenericWriteRepository<Gallery>, IGalleryWriteRepository
{
    public GalleryWriteRepository(AppDbContext context) : base(context)
    {
    }
}
