using System.Threading.Tasks;
using Facil.Erp.Models.TokenAuth;
using Facil.Erp.Web.Controllers;
using Shouldly;
using Xunit;

namespace Facil.Erp.Web.Tests.Controllers
{
    public class HomeController_Tests: ErpWebTestBase
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