using System.Collections.Generic;
using Facil.Erp.Roles.Dto;

namespace Facil.Erp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
