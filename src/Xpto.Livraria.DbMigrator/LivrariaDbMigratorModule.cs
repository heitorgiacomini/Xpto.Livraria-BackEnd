using Xpto.Livraria.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Xpto.Livraria.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LivrariaEntityFrameworkCoreModule),
    typeof(LivrariaApplicationContractsModule)
    )]
public class LivrariaDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
