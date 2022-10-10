using TestExtraProperties.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestExtraProperties.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestExtraPropertiesController : AbpControllerBase
{
    protected TestExtraPropertiesController()
    {
        LocalizationResource = typeof(TestExtraPropertiesResource);
    }
}
