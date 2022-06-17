using System;
using System.Collections.Generic;
using System.Text;
using Xpto.Livraria.Localization;
using Volo.Abp.Application.Services;

namespace Xpto.Livraria;

/* Inherit your application services from this class.
 */
public abstract class LivrariaAppService : ApplicationService
{
    protected LivrariaAppService()
    {
        LocalizationResource = typeof(LivrariaResource);
    }
}
