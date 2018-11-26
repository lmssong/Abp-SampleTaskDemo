using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamleTaskDemo.MultiTenancy.Dto;

namespace SamleTaskDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
