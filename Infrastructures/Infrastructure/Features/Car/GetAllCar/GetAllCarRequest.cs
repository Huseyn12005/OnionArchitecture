using MediatR;

namespace Infrastructure.Features.GetAllCar;

public class GetAllCarRequest : IRequest<GetAllCarResponse>
{
    public int Page { get; set; } = 0;
    public int Count { get; set; } = 10;
}
