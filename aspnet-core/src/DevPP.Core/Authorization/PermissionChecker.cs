using Abp.Authorization;
using DevPP.Authorization.Roles;
using DevPP.Authorization.Users;

namespace DevPP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
