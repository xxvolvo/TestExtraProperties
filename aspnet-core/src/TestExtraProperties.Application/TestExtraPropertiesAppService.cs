using System;
using System.Collections.Generic;
using System.Text;
using TestExtraProperties.Localization;
using Volo.Abp.Application.Services;

namespace TestExtraProperties;

/* Inherit your application services from this class.
 */
public abstract class TestExtraPropertiesAppService : ApplicationService
{
    protected TestExtraPropertiesAppService()
    {
        LocalizationResource = typeof(TestExtraPropertiesResource);
    }
}
