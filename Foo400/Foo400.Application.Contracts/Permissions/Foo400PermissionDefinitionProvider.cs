using Foo400.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Foo400.Permissions
{
    public class Foo400PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Foo400Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(Foo400Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Foo400Resource>(name);
        }
    }
}
