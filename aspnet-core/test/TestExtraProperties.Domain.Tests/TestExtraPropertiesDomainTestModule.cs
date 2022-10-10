using TestExtraProperties.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TestExtraProperties;

[DependsOn(
    typeof(TestExtraPropertiesEntityFrameworkCoreTestModule)
    )]
public class TestExtraPropertiesDomainTestModule : AbpModule
{

}
