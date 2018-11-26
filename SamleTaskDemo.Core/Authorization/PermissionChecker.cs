using Abp.Authorization;
using SamleTaskDemo.Authorization.Roles;
using SamleTaskDemo.Authorization.Users;

namespace SamleTaskDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
