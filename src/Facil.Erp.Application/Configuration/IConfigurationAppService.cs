using System.Threading.Tasks;
using Facil.Erp.Configuration.Dto;

namespace Facil.Erp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
