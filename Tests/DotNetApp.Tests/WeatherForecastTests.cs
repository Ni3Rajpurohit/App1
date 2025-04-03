using Xunit;
using DotNetApp.Controllers;
using Microsoft.AspNetCore.Mvc;

public class WeatherForecastTests
{
    [Fact]
    public void GetWeather_ReturnsOkResult()
    {
        var controller = new WeatherForecastController();
        var result = controller.Get();
        Assert.IsType<OkObjectResult>(result);
    }
}
