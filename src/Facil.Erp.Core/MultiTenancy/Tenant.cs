using Abp.MultiTenancy;
using Facil.Erp.Authorization.Users;

namespace Facil.Erp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
