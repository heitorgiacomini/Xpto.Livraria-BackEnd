using Volo.Abp.Settings;

namespace Xpto.Livraria.Settings;

public class LivrariaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LivrariaSettings.MySetting1));
    }
}
