using Domain.DTOs.Cars;

namespace Infrastructure.Features.GetAllCar;

public class GetAllCarResponse
{
    public bool IsSuccess { get; set; }
    public string Message{ get; set; }
    public ICollection<GetCarDto> Cars { get; set; }
}
