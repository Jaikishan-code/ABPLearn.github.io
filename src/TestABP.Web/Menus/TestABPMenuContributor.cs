using System.Threading.Tasks;
using TestABP.Permissions;
using TestABP.Localization;
using TestABP.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace TestABP.Web.Menus;

public class TestABPMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<TestABPResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                TestABPMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
        if (await context.IsGrantedAsync(TestABPPermissions.Student.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(TestABPMenus.Student, l["Student"], "/Students/Student")
            );
        }
        if (await context.IsGrantedAsync(TestABPPermissions.Product.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(TestABPMenus.Product, l["Product"], "/Products/Product")
            );
        }
    }
}
