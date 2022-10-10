using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestExtraProperties.Data;
using Volo.Abp.DependencyInjection;

namespace TestExtraProperties.EntityFrameworkCore;

public class EntityFrameworkCoreTestExtraPropertiesDbSchemaMigrator
    : ITestExtraPropertiesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTestExtraPropertiesDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TestExtraPropertiesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TestExtraPropertiesDbContext>()
            .Database
            .MigrateAsync();
    }
}
