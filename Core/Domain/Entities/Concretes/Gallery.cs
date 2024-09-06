using Domain.Entities.Abratcts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Concretes;

public class Gallery : BaseEntity
{
    public string Name { get; set; }

    // Foreign Keys
    public long? UserId { get; set; }

    // Navigation Properties
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }

    public ICollection<Car> Cars { get; set; }
}
