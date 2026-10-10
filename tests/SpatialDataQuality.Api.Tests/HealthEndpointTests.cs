
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace SpatialDataQuality.Api.Tests;

public class HealthEndpointTests
{
    [Fact]
    public async Task GetHealth_ReturnsHealthyStatus()
    {
        // Arrange: start the API in an in-process test server.
        await using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();

        // Act: make a real HTTP request to the endpoint.
        using var response = await client.GetAsync("/health");
        var content = await response.Content.ReadAsStringAsync();

        // Assert: verify both the HTTP status and response body.
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("""{"status":"Healthy"}""", content);
    }
}
