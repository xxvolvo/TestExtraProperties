using TestExtraProperties.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestExtraProperties.Permissions;

public class TestExtraPropertiesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestExtraPropertiesPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestExtraPropertiesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestExtraPropertiesResource>(name);
    }
}
