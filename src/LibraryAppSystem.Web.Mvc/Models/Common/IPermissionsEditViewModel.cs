using System.Collections.Generic;
using LibraryAppSystem.Roles.Dto;

namespace LibraryAppSystem.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}