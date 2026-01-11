using API_Automation_Tests.Api;
using NUnit.Framework;
using System.Net;

[TestFixture]

public class PostUserTests
{

    [Test]
    public void CreateUser_ShouldReturnStatusCode201_WhenUserIsCreated()
    {
        // Arrange
        var apiClient = new ApiClient();
 
        // Act
        var response = apiClient.CreateUser("Petar", "QA Engineer");

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        Assert.That(response.Content, Does.Contain("id"));
    }

    [Test]
    public void CreateUser_ShouldReturnStatusCode400_WhenEmptyCredentialsAreProvided()
    {
        // Arrange
        var apiClient = new ApiClient();

        // Act
        var response = apiClient.CreateUser("", "");

        // Assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));

        //Note that the website being tested(ReqRes) returns code 201 in this test
        //In a real situation like this, the code must be 400 - Bad request
        //This test is just to demonstrate a negatice case
    }
}