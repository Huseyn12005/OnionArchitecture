using Domain.DTOs.Users;
using Domain.Entities.Concretes;

namespace Application.Services;

public interface IUserService
{
    Task<string> AddAsync(AddUserDto model);
    Task<ICollection<GetUserDto>> GetAllUsers(int page = 0, int count = 5);
}
