using System.Collections.Generic;
using Facil.Erp.Roles.Dto;

namespace Facil.Erp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
