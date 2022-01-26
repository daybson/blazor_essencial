using BlazorWebAssemblyForm.Auth;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebAssemblyForm
{
	public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddAuthorizationCore();

            //Scoped = serviço é criado em cada solicitação do cliente
            builder.Services.AddScoped<AuthenticationStateProvider, DemoAuthStateProvider>();

            await builder.Build().RunAsync();
        }
    }
}
