using System.Collections.Generic;
using Facil.Erp.Roles.Dto;

namespace Facil.Erp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}