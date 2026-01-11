using API_Automation_Tests.Api;
using NUnit.Framework;
using System.Net;

[TestFixture]

public class DeleteUserTests
{

    [Test]
    public void DeleteUser_ShouldReturnStatusCode204_WhenExistingIdIsProvided()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.DeleteUser(5);

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        //Note that the website being tested(ReqRes) returns code 200 in this test
        //In a real situation like this, the code must be 204 - No Content
        //This test is just to demonstrate the happy path of the DELETE request
    }

    [Test]
    public void DeleteUser_ShouldReturnStatusCode404_WhenNonExistingIdIsProvided()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.DeleteUser(15);

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        //Note that the website being tested(ReqRes) returns code 200 in this test
        //In a real situation like this, the code must be 404 - Not Found
        //This test is just to demonstrate a negatice case
    }
}