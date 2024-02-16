namespace Verisoft.Codereview.DotnetAspire.Web;

public class ApiClient(HttpClient httpClient)
{
    public Task<User[]?> GetWeatherAsync()
        => httpClient.GetFromJsonAsync<User[]>("/users");
}

public record User(Guid Id, string Name, string FirstName, string LastName, string Email, string Description);