using System.Threading.Tasks;
using Abp.Application.Services;
using DevPP.Authorization.Accounts.Dto;

namespace DevPP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
