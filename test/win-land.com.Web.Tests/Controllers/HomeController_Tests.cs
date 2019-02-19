using System.Threading.Tasks;
using win-land.com.Web.Controllers;
using Shouldly;
using Xunit;

namespace win-land.com.Web.Tests.Controllers
{
    public class HomeController_Tests: comWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
