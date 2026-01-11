using API_Automation_Tests.Api;
using NUnit.Framework;
using System.Net;

[TestFixture]
public class GetUserTests
{
    [Test]
    public void GetUserByID_ShouldReturnStatusCode200_WhenUserExists()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.GetUserByID(6);

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(response.Content, Does.Contain("id"));
        Assert.That(response.Content, Does.Contain("name"));
        Assert.That(response.Content, Does.Contain("username"));
        Assert.That(response.Content, Does.Contain("email"));
        Assert.That(response.Content, Does.Contain("address"));
    }

    [Test]
    public void GetAllUsers_ShouldReturnStatusCode200()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.GetAllUsers();

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(response.Content, Does.Contain("id"));
        Assert.That(response.Content, Does.Contain("name"));
        Assert.That(response.Content, Does.Contain("username"));
        Assert.That(response.Content, Does.Contain("email"));
        Assert.That(response.Content, Does.Contain("address"));
    }

    [Test]
    public void GetUserByID_ShouldReturnStatusCode404_WhenUserDoesntExist()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.GetUserByID(13);

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
    }
}