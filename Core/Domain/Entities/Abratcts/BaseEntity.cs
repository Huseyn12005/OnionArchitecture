namespace Domain.Entities.Abratcts;

public abstract class BaseEntity
{
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}
