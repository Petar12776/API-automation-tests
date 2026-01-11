namespace API_Automation_Tests.Api;

using RestSharp;

public class ApiClient 
{

    public readonly RestClient _client;

    public ApiClient()
    {
        _client = new RestClient("https://jsonplaceholder.typicode.com/");
    }

    public RestResponse GetUserByID(int userID)
    {
        var request = new RestRequest($"/users/userID", Method.Get);

        return _client.Execute(request);
    }

    public RestResponse GetAllUsers()
    {
        var request = new RestRequest("/users", Method.Get);

        return _client.Execute(request);
    }
    
    public RestResponse CreateUser(string name, string job)
    {
        var request = new RestRequest("/users", Method.Post);

        request.AddJsonBody(new { name = name, job = job });

        return _client.Execute(request);
    }

    public RestResponse DeleteUser(int userID)
    {
        var request = new RestRequest($"/users/userID", Method.Delete);

        return _client.Execute(request);
    }

    public RestResponse UpdateUser(int userID, string name, string job)
    {
        var request = new RestRequest($"users/userID", Method.Put);

        request.AddJsonBody(new { name = name, job = job });

        return _client.Execute(request);
    } 
}
