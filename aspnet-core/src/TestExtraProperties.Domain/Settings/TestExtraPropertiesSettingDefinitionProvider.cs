using Volo.Abp.Settings;

namespace TestExtraProperties.Settings;

public class TestExtraPropertiesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestExtraPropertiesSettings.MySetting1));
    }
}
