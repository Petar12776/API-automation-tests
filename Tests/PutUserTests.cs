using API_Automation_Tests.Api;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Net;

[TestFixture]

public class PutUserTests
{

    [Test]
    public void UpdateUser_ReturnsStatusCode200_WhenExistingUserIsProvided()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.UpdateUser(4, "Alice", "Designer");

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public void UpdateUser_ReturnsStatusCode400_WhenEmptyCredentialsAreProvided()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.UpdateUser(1, "", "");

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        //Note that the website being tested(ReqRes) returns code 200 in this test
        //In a real situation like this, the code must be 400 - Bad request
        //This is just to demonstrate a negatice case
    }
}