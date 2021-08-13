using System.Threading.Tasks;
using AliFitnessAE_SP.Models.TokenAuth;
using AliFitnessAE_SP.Web.Controllers;
using Shouldly;
using Xunit;

namespace AliFitnessAE_SP.Web.Tests.Controllers
{
    public class HomeController_Tests: AliFitnessAE_SPWebTestBase
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