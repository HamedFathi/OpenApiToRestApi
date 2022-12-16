namespace OpenApiToRestApi.Models;

public class BearerToken
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string GrantType { get; set; }
    public string Password { get; set; }
    public string Scope { get; set; }
    public string UserName { get; set; }
}