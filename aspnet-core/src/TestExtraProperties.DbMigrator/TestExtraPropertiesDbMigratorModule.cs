using TestExtraProperties.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TestExtraProperties.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestExtraPropertiesEntityFrameworkCoreModule),
    typeof(TestExtraPropertiesApplicationContractsModule)
    )]
public class TestExtraPropertiesDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
