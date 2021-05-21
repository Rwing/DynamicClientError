using Bar430.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Bar430.Permissions
{
    public class Bar430PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Bar430Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(Bar430Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Bar430Resource>(name);
        }
    }
}
