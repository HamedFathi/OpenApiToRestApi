// ReSharper disable UnusedMember.Global

using Microsoft.OpenApi.Models;
using OpenApiExtended;
using OpenApiToRestApi.Enums;
using OpenApiToRestApi.Models;
using OpenApiToRestApi.Templates;
using System;

namespace OpenApiToRestApi;

public static class OpenApiToRestApiExtensions
{
    public static string ToRestApi(this OpenApiDocument openApiDocument, Setting setting = null)
    {
        if (openApiDocument == null) throw new ArgumentNullException(nameof(openApiDocument));
        setting = setting ?? new Setting();
        var schemes = openApiDocument.GetOpenApiSecuritySchemes(x => x.Scheme == "bearer");
        var status = schemes.Count > 0;
        /* if (status && axiosSetting.BearerToken == null)
             throw new ArgumentNullException("BearerToken", "OpenApi document requires a bearer token setting.");
        */

        var sourceTemplate = "";
        switch (setting.TemplateType)
        {
            case TemplateType.Axios:
                sourceTemplate = ClientTemplate.AxiosTemplate;
                break;

            case TemplateType.Fetch:
                sourceTemplate = ClientTemplate.FetchTemplate;
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }

        return null;
    }

    private static string[] CommentProvider(string comment)
    {
        if (string.IsNullOrWhiteSpace(comment))
        {
            return null;
        }
        var lines = comment.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        return lines;
    }
}