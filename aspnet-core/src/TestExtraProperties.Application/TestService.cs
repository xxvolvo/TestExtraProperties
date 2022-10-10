using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.Guids;
using Volo.Abp.Identity;

namespace TestExtraProperties
{
    [AllowAnonymous]
    public class TestService : TestExtraPropertiesAppService
    {
        private readonly IIdentityUserRepository _identityUserRepository;

        public TestService(IIdentityUserRepository identityUserRepository)
        {
            _identityUserRepository = identityUserRepository;
        }

        public async Task Test()
        {
            var user = new IdentityUser(GuidGenerator.Create(), "Test", "test@abp.io");
            user.SetProperty("LineManagerId", GuidGenerator.Create());
            await _identityUserRepository.InsertAsync(user);
        }


    }
}
