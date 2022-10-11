using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BoulderingPoints.Pages;

public class Index_Tests : BoulderingPointsWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
