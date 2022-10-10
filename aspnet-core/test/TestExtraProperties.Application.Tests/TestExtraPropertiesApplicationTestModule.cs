using Volo.Abp.Modularity;

namespace TestExtraProperties;

[DependsOn(
    typeof(TestExtraPropertiesApplicationModule),
    typeof(TestExtraPropertiesDomainTestModule)
    )]
public class TestExtraPropertiesApplicationTestModule : AbpModule
{

}
