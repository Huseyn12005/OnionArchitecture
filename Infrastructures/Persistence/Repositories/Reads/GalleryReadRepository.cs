using Application.Repositories.Reads;
using Domain.Entities.Concretes;
using Persistence.Contexts;
using Persistence.Repositories.Commons;

namespace Persistence.Repositories.Reads;

public class GalleryReadRepository : GenericReadRepository<Gallery>, IGalleryReadRepository
{
    public GalleryReadRepository(AppDbContext context) : base(context)
    {
    }
}
