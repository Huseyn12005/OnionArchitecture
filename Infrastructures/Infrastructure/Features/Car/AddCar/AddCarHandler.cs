using Application.UnitOfWorks;
using Domain.Entities.Concretes;
using MediatR;

namespace Infrastructure.Features.AddCar;

public class AddCarHandler : IRequestHandler<AddCarRequest, AddCarResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddCarHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<AddCarResponse> Handle(AddCarRequest request, CancellationToken cancellationToken)
    {
        try
        {
            Car newCar = new Car()
            {
                Make = request.Make,
                Model = request.Model,
                Price = request.Price,
                FabricationDate = request.FabricationDate
            };

            await _unitOfWork.CarWriteRepository.AddAsync(newCar);
            await _unitOfWork.CarWriteRepository.SaveAllChangesAsync();

            return new AddCarResponse()
            {
                Message = "Car Ugurla Elave edildi!!!",
                IsSuccess = true
            };
        }
        catch (Exception ex)
        {
            return new AddCarResponse()
            {
                Message = ex.Message,
                IsSuccess = false
            };
        }
    }
}
