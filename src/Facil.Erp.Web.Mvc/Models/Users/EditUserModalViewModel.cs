using System.Collections.Generic;
using System.Linq;
using Facil.Erp.Roles.Dto;
using Facil.Erp.Users.Dto;

namespace Facil.Erp.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
