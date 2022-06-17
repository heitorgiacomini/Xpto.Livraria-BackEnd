using Xpto.Livraria.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Xpto.Livraria;

[DependsOn(
    typeof(LivrariaEntityFrameworkCoreTestModule)
    )]
public class LivrariaDomainTestModule : AbpModule
{

}
