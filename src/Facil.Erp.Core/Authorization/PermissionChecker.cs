using Abp.Authorization;
using Facil.Erp.Authorization.Roles;
using Facil.Erp.Authorization.Users;

namespace Facil.Erp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
