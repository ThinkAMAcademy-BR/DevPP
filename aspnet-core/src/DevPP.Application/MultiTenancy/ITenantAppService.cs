using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DevPP.MultiTenancy.Dto;

namespace DevPP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
