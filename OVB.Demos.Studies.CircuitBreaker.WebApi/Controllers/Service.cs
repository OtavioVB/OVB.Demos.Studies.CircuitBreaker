namespace OVB.Demos.Studies.CircuitBreaker.WebApi.Controllers;

public class Service
{
    private HttpClient _httpClient;

    public Service(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
