using BoulderingPoints.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BoulderingPoints.Permissions;

public class BoulderingPointsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BoulderingPointsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BoulderingPointsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BoulderingPointsResource>(name);
    }
}
