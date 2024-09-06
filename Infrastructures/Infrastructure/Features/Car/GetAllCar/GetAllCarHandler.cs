using Application.UnitOfWorks;
using Domain.DTOs.Cars;
using Domain.DTOs.Users;
using MediatR;

namespace Infrastructure.Features.GetAllCar;

public class GetAllCarHandler : IRequestHandler<GetAllCarRequest, GetAllCarResponse>
{
    private readonly IUnitOfWork _unitOfWrok;

    public GetAllCarHandler(IUnitOfWork unitOfWrok)
    {
        _unitOfWrok = unitOfWrok;
    }

    async Task<GetAllCarResponse> IRequestHandler<GetAllCarRequest, GetAllCarResponse>.Handle(GetAllCarRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var result = (await _unitOfWrok.CarReadrepository.GetAllAsync())
            .Skip(request.Page * request.Count)
            .Take(request.Count)
            .Select(x => new GetCarDto()
            {
                Make = x.Make,
                Model = x.Model,
                Price = x.Price,
            });

            return new GetAllCarResponse()
            {
                IsSuccess = true,
                Message = "Data Ugurla elde edildi",
                Cars = result.ToList()
            };
        }
        catch (Exception ex)
        {
            return new GetAllCarResponse()
            {
                IsSuccess = false,
                Message = ex.Message,
                Cars = null
            };
        }
    }
}
