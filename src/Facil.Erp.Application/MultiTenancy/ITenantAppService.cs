using Abp.Application.Services;
using Facil.Erp.MultiTenancy.Dto;

namespace Facil.Erp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

