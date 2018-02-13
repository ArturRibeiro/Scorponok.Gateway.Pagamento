﻿using Scorponok.Gateway.Pagamento.Unit.Test.Integration.Tests;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Scorponok.Gateway.Pagamento.Unit.Test.Integration.Tests
{
    public static class FluentHttpRequestFactory
    {
        public static Action<AppSettings> _settings;

        static FluentHttpRequestFactory()
        {
            _settings = (AppSettings settings) =>
            {
                settings.AddWebHostPath(@"C:\Users\scorponok\Source\github\Gateway-Pagamento\Adquirentes\src\Scorponok.Adquirente.Web.UI.Api");
                settings.AddEnvironment("ASPNETCORE_ENVIRONMENT", "Integration.Test");
                settings.AddEnvironment("REGISTRY_CONFIG_FILE", "appsettings.json");
                settings.AddEnvironment("REGISTRY_USE_DOCKER_SECRETS", "false");
            };
        }

        #region Métodos Públicos
        public static async Task<HttpResponseMessage> Get(string requestUri)
            => await Get(requestUri, "");

        public static async Task<HttpResponseMessage> Post(string requestUri, object value)
            => await Post(requestUri, value, "");

        public static async Task<HttpResponseMessage> Put(string requestUri, object value)
            => await Put(requestUri, value, "");

        public static async Task<HttpResponseMessage> Patch(string requestUri, object value)
            => await Patch(requestUri, value, "");

        public static async Task<HttpResponseMessage> Delete(string requestUri)
            => await Delete(requestUri, "");

        public static async Task<HttpResponseMessage> PostFile(string requestUri, string filePath, string apiParamName)
            => await PostFile(requestUri, filePath, apiParamName, "");

        #endregion

        #region Métodos Privados
        private static async Task<HttpResponseMessage> Get(string requestUri, string bearerToken)
        {
            var builder = FluentHttpRequestBuilder
                    .CreateNew(_settings)
                        .AddMethod(HttpMethod.Get)
                        .AddUri(requestUri)
                        .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        private static async Task<HttpResponseMessage> Post(string requestUri, object value, string bearerToken)
        {
            var builder = FluentHttpRequestBuilder
                    .CreateNew(_settings)
                        .AddMethod(HttpMethod.Post)
                        .AddUri(requestUri)
                        .AddContent(new JsonContent(value))
                        .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        private static async Task<HttpResponseMessage> Put(string requestUri, object value, string bearerToken)
        {
            var builder = FluentHttpRequestBuilder
                    .CreateNew(_settings)
                        .AddMethod(HttpMethod.Put)
                        .AddUri(requestUri)
                        .AddContent(new JsonContent(value))
                        .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        private static async Task<HttpResponseMessage> Patch(string requestUri, object value, string bearerToken)
        {
            var builder = FluentHttpRequestBuilder
                    .CreateNew(_settings)
                        .AddMethod(new HttpMethod("PATCH"))
                        .AddUri(requestUri)
                        .AddContent(new PatchContent(value))
                        .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        private static async Task<HttpResponseMessage> Delete(string requestUri, string bearerToken)
        {
            var builder = FluentHttpRequestBuilder
                    .CreateNew(_settings)
                        .AddMethod(HttpMethod.Delete)
                        .AddUri(requestUri)
                        .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        private static async Task<HttpResponseMessage> PostFile(string requestUri, string filePath, string apiParamName, string bearerToken)
        {
            var builder = FluentHttpRequestBuilder
                    .CreateNew(_settings)
                        .AddMethod(HttpMethod.Post)
                        .AddUri(requestUri)
                        .AddContent(new FileContent(filePath, apiParamName))
                        .AddBearerToken(bearerToken);

            return await builder.SendAsync();
        }

        #endregion
    }
}