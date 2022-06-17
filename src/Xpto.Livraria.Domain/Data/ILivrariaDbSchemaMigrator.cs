using System.Threading.Tasks;

namespace Xpto.Livraria.Data;

public interface ILivrariaDbSchemaMigrator
{
    Task MigrateAsync();
}
