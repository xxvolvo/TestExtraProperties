using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestExtraProperties.Data;

/* This is used if database provider does't define
 * ITestExtraPropertiesDbSchemaMigrator implementation.
 */
public class NullTestExtraPropertiesDbSchemaMigrator : ITestExtraPropertiesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
