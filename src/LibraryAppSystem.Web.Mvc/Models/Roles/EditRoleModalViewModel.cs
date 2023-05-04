using Abp.AutoMapper;
using LibraryAppSystem.Roles.Dto;
using LibraryAppSystem.Web.Models.Common;

namespace LibraryAppSystem.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
