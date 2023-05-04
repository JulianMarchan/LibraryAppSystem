using Abp.Authorization;
using LibraryAppSystem.Authorization.Roles;
using LibraryAppSystem.Authorization.Users;

namespace LibraryAppSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
