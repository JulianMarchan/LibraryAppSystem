using System.Threading.Tasks;
using LibraryAppSystem.Models.TokenAuth;
using LibraryAppSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibraryAppSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: LibraryAppSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}