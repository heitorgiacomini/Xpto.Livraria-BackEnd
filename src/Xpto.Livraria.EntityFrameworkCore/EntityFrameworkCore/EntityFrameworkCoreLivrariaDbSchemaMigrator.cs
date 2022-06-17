using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xpto.Livraria.Data;
using Volo.Abp.DependencyInjection;

namespace Xpto.Livraria.EntityFrameworkCore;

public class EntityFrameworkCoreLivrariaDbSchemaMigrator
    : ILivrariaDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLivrariaDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LivrariaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LivrariaDbContext>()
            .Database
            .MigrateAsync();
    }
}
