using OpenApiToRestApi.Enums;

namespace OpenApiToRestApi.Models;

public class Setting
{
    public BearerToken BearerToken { get; set; }
    public string ClientClassName { get; set; } = "Client";
    public string CustomComment { get; set; } = "";
    public TemplateType TemplateType { get; set; } = TemplateType.Fetch;
}