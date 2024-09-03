using System;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EWeLink.Cube.Api
{
    public class LinkFactory(IServiceProvider serviceProvider) : ILinkFactory
    {
        public ILink Create(string ipAddress, string? accessToken = null) => Create(IPAddress.Parse(ipAddress), accessToken);

        public ILink Create(IPAddress ipAddress, string? accessToken = null) 
            => new Link(ipAddress, accessToken, serviceProvider.GetRequiredService<IHttpClientFactory>(), serviceProvider.GetRequiredService<ILogger<Link>>());
    }
}