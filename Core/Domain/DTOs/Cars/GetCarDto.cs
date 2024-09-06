using Domain.Enums;

namespace Domain.DTOs.Cars;

public class GetCarDto
{
    public MakeEnum Make { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
}
