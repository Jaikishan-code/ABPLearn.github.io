using TestABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestABP.Permissions;

public class TestABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestABPPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestABPPermissions.MyPermission1, L("Permission:MyPermission1"));

        var studentPermission = myGroup.AddPermission(TestABPPermissions.Student.Default, L("Permission:Student"));
        studentPermission.AddChild(TestABPPermissions.Student.Create, L("Permission:Create"));
        studentPermission.AddChild(TestABPPermissions.Student.Update, L("Permission:Update"));
        studentPermission.AddChild(TestABPPermissions.Student.Delete, L("Permission:Delete"));

        var productPermission = myGroup.AddPermission(TestABPPermissions.Product.Default, L("Permission:Product"));
        productPermission.AddChild(TestABPPermissions.Product.Create, L("Permission:Create"));
        productPermission.AddChild(TestABPPermissions.Product.Update, L("Permission:Update"));
        productPermission.AddChild(TestABPPermissions.Product.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestABPResource>(name);
    }
}
