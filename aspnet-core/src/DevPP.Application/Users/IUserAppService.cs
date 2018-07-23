using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DevPP.Roles.Dto;
using DevPP.Users.Dto;

namespace DevPP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
