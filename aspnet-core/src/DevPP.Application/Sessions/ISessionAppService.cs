using System.Threading.Tasks;
using Abp.Application.Services;
using DevPP.Sessions.Dto;

namespace DevPP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
