using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Xpto.Livraria.Localization;

namespace Xpto.Livraria.Permissions;

public class LivrariaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LivrariaPermissions.MyPermission1, L("Permission:MyPermission1"));

        var livrariaGroup = context.AddGroup(LivrariaPermissions.GroupName, L("Permission:Livraria"));

        var booksPermission = livrariaGroup.AddPermission(LivrariaPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(LivrariaPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(LivrariaPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(LivrariaPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = livrariaGroup.AddPermission(LivrariaPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(LivrariaPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(LivrariaPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(LivrariaPermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LivrariaResource>(name);
    }
}
