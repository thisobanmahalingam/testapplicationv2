using Microsoft.Extensions.Logging;
using Moq;
using testapplicationv2.Controllers;

namespace xunitproject
{
    public class WeatherForecastControllerTests
    {
        private readonly Mock<ILogger<WeatherForecastController>> _mockLogger;
        private readonly WeatherForecastController _controller;

        public WeatherForecastControllerTests()
        {
            _mockLogger = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_mockLogger.Object);
        }

        [Fact]
        public void Get_ReturnsWeatherForecasts()
        {
            // Act
            var result = _controller.Get();

            // Assert
            Assert.NotNull(result);
            var weatherForecasts = result.ToList();
            Assert.Equal(5, weatherForecasts.Count);
            foreach (var forecast in weatherForecasts)
            {
                Assert.InRange(forecast.TemperatureC, -20, 55);
                Assert.Contains(forecast.Summary, WeatherForecastController.Summaries);
            }
        }
        [Fact]
        public void Get_ReturnsWeatherForecasts2()
        {
            // Act
            var result = _controller.Get();

            // Assert
            Assert.NotNull(result);
            var weatherForecasts = result.ToList();
            Assert.Equal(5, weatherForecasts.Count);
            foreach (var forecast in weatherForecasts)
            {
                Assert.InRange(forecast.TemperatureC, -20, 55);
                Assert.Contains(forecast.Summary, WeatherForecastController.Summaries);
            }
        }

    }
}