using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Yarp.ReverseProxy.Forwarder
{
    public interface IPostTransformMiddleware
    {
        Task InvokeAsync(HttpContext context, HttpRequestMessage proxyRequest);
    }
}
