using Application.Repositories;
using Application.Repositories.Reads;
using Application.Repositories.Writes;

namespace Application.UnitOfWorks;

public interface IUnitOfWork
{
    public ICarReadrepository CarReadrepository { get; set; }
    public ICarWriteRepository CarWriteRepository { get; set; }
    public IUserWriteRepository UserWriteRepository { get; set; }
    public IUserReadRepository UserReadRepository { get; set; }
    public IGalleryReadRepository GalleryReadRepository { get; set; }
    public IGalleryWriteRepository GalleryWriteRepository { get; set; }
}
