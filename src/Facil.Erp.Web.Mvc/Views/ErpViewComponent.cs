using Abp.AspNetCore.Mvc.ViewComponents;

namespace Facil.Erp.Web.Views
{
    public abstract class ErpViewComponent : AbpViewComponent
    {
        protected ErpViewComponent()
        {
            LocalizationSourceName = ErpConsts.LocalizationSourceName;
        }
    }
}
