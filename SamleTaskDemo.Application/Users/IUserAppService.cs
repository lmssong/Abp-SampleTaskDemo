using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamleTaskDemo.Roles.Dto;
using SamleTaskDemo.Users.Dto;

namespace SamleTaskDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}