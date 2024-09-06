using Application.Services;
using Application.UnitOfWorks;
using Domain.DTOs.Users;
using Domain.Entities.Concretes;

namespace Infrastructure.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<string> AddAsync(AddUserDto model)
    {
        // Validation edilmelidir.
        User newUser = new User()
        {
            UserName = model.UserName,
            Name = model.Name,
            Email = model.Email,
            Surname = model.Surname,
        };

        try
        {
            await _unitOfWork.UserWriteRepository.AddAsync(newUser);
            await _unitOfWork.UserWriteRepository.SaveAllChangesAsync();
            return "Data Ugurla elave edildi...";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public async Task<ICollection<GetUserDto>> GetAllUsers(int page = 0, int count = 5)
    {
        var result = (await _unitOfWork.UserReadRepository.GetAllAsync())
             .Skip(page * count)
             .Take(count)
             .Select(x => new GetUserDto()
             {
                 Email = x.Email,
                 Name = x.Name,
                 Surname = x.Surname,
             });

        return result.ToList();
    }
}
