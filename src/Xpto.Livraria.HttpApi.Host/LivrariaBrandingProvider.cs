using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Xpto.Livraria;

[Dependency(ReplaceServices = true)]
public class LivrariaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Livraria";
}
