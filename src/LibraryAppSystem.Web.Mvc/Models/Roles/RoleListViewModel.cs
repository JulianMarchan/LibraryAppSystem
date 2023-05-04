using System.Collections.Generic;
using LibraryAppSystem.Roles.Dto;

namespace LibraryAppSystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
