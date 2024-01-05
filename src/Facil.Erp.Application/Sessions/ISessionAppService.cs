using System.Threading.Tasks;
using Abp.Application.Services;
using Facil.Erp.Sessions.Dto;

namespace Facil.Erp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
