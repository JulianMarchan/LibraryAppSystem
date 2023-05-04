using System.Collections.Generic;
using LibraryAppSystem.Roles.Dto;

namespace LibraryAppSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
