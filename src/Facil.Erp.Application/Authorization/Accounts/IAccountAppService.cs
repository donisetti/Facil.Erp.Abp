using System.Threading.Tasks;
using Abp.Application.Services;
using Facil.Erp.Authorization.Accounts.Dto;

namespace Facil.Erp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
