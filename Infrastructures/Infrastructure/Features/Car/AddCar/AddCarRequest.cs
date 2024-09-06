using Domain.Enums;
using MediatR;
namespace Infrastructure.Features.AddCar;

public class AddCarRequest : IRequest<AddCarResponse>
{
    public MakeEnum Make { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public DateTime FabricationDate { get; set; }
}
