using Xpto.Livraria.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Xpto.Livraria.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LivrariaController : AbpControllerBase
{
    protected LivrariaController()
    {
        LocalizationResource = typeof(LivrariaResource);
    }
}
