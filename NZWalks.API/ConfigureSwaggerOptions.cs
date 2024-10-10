﻿using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace NZWalks.API
{
    public class ConfigureSwaggerOptions : IConfigureNamedOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider apiVersionDescriptionProvider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            this.apiVersionDescriptionProvider = apiVersionDescriptionProvider;
        }

        public void Configure(string? name, SwaggerGenOptions options)
        {
            foreach (var item in apiVersionDescriptionProvider.ApiVersionDescriptions)
            {
                try
                {
                    options.SwaggerDoc(item.GroupName, CreateVersionInfo(item));
                }
                catch (ArgumentException)
                {
                    // Ignore the exception if the key already exists
                    // Optionally, you can log this event for troubleshooting purposes
                }
            }
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var item in apiVersionDescriptionProvider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(item.GroupName, CreateVersionInfo(item));
            }
        }

        private OpenApiInfo CreateVersionInfo(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = "Your versioned API",
                Version = description.ApiVersion.ToString()
            };

            return info;
        }
    }
}
