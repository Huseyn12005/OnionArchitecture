using Application.Repositories;
using Application.Repositories.Reads;
using Application.Repositories.Writes;
using Application.UnitOfWorks;

namespace Persistence.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(ICarReadrepository carReadrepository, ICarWriteRepository carWriteRepository, IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository, IGalleryReadRepository galleryReadRepository, IGalleryWriteRepository galleryWriteRepository)
    {
        CarReadrepository = carReadrepository;
        CarWriteRepository = carWriteRepository;
        UserWriteRepository = userWriteRepository;
        UserReadRepository = userReadRepository;
        GalleryReadRepository = galleryReadRepository;
        GalleryWriteRepository = galleryWriteRepository;
    }

    public ICarReadrepository CarReadrepository { get; set; }
    public ICarWriteRepository CarWriteRepository { get; set; }
    public IUserWriteRepository UserWriteRepository { get; set; }
    public IUserReadRepository UserReadRepository { get; set; }
    public IGalleryReadRepository GalleryReadRepository { get; set; }
    public IGalleryWriteRepository GalleryWriteRepository { get; set; }
}
