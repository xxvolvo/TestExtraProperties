using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Data;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Xunit;

namespace TestExtraProperties.Samples;

/* This is just an example test class.
 * Normally, you don't test code of the modules you are using
 * (like IdentityUserManager here).
 * Only test your own domain services.
 */
public class SampleDomainTests : TestExtraPropertiesDomainTestBase
{
    private readonly IIdentityUserRepository _identityUserRepository;
    private readonly IdentityUserManager _identityUserManager;
    private readonly IGuidGenerator _guidGenerator;

    public SampleDomainTests()
    {
        _identityUserRepository = GetRequiredService<IIdentityUserRepository>();
        _identityUserManager = GetRequiredService<IdentityUserManager>();
        _guidGenerator = GetRequiredService<IGuidGenerator>();
    }

    [Fact]
    public async Task Should_Set_Email_Of_A_User()
    {
        IdentityUser adminUser;

        /* Need to manually start Unit Of Work because
         * FirstOrDefaultAsync should be executed while db connection / context is available.
         */
        await WithUnitOfWorkAsync(async () =>
        {
            adminUser = await _identityUserRepository
                .FindByNormalizedUserNameAsync("ADMIN");

            await _identityUserManager.SetEmailAsync(adminUser, "newemail@abp.io");
            await _identityUserRepository.UpdateAsync(adminUser);
        });

        adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync("ADMIN");
        adminUser.Email.ShouldBe("newemail@abp.io");
    }
    //[Fact]
    //public async Task TestLineManagerId()
    ////{
    ////    await WithUnitOfWorkAsync(async () =>
    ////    {
    ////        var user = new IdentityUser(_guidGenerator.Create(), "Test", "test@abp.io");
    ////        user.SetProperty()
    ////        await _identityUserRepository.InsertAsync(user);
    ////    });

    ////    await WithUnitOfWorkAsync(async () =>
    ////    {
    ////        //var user = _identityUserManager.FindByEmailAsync()
    ////        //await _identityUserRepository.InsertAsync(user);
    ////    });
    //}
}
