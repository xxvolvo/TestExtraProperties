using System.Threading.Tasks;

namespace TestExtraProperties.Data;

public interface ITestExtraPropertiesDbSchemaMigrator
{
    Task MigrateAsync();
}
