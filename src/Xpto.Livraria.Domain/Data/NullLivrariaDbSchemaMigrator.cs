using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Xpto.Livraria.Data;

/* This is used if database provider does't define
 * ILivrariaDbSchemaMigrator implementation.
 */
public class NullLivrariaDbSchemaMigrator : ILivrariaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
