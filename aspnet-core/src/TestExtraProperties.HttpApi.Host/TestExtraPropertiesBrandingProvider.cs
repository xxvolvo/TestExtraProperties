using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestExtraProperties;

[Dependency(ReplaceServices = true)]
public class TestExtraPropertiesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestExtraProperties";
}
