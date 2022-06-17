using Volo.Abp.Modularity;

namespace Xpto.Livraria;

[DependsOn(
    typeof(LivrariaApplicationModule),
    typeof(LivrariaDomainTestModule)
    )]
public class LivrariaApplicationTestModule : AbpModule
{

}
