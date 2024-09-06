using Domain.Entities.Abratcts;
using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Concretes;

public class Car : BaseEntity
{
    public MakeEnum Make { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public DateTime FabricationDate { get; set; }

    // Foreign Keys
    public long? GalleryId { get; set; }
    public long? UserId { get; set; }

    // Navigation Properties
    [ForeignKey(nameof(GalleryId))]
    public Gallery? Gallery { get; set; }

    [ForeignKey(nameof(UserId))]
    public User? User { get; set; }
}
