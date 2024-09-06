using Domain.Entities.Abratcts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Concretes;

public class User : BaseEntity
{
    public string UserName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string? PasswordHash { get; set; }

    // Foreign Key
    public long? GalleryId { get; set; }

    // Navigation Propeties
    [ForeignKey(nameof(GalleryId))]
    public Gallery? Gallery { get; set; }

    public ICollection<Car> Cars { get; set; }
}
