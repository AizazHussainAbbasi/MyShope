using Abp.Authorization;
using AliFitnessAE_SP.Authorization.Roles;
using AliFitnessAE_SP.Authorization.Users;

namespace AliFitnessAE_SP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
