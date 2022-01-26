using Microsoft.AspNetCore.Components.Authorization;

using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorWebAssemblyForm.Auth
{
    public class DemoAuthStateProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(1000);

            var usuario = new ClaimsIdentity(
                new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, "Daybson"),
                    new Claim(ClaimTypes.Role, "Admin")
                },
                "demo");

            return
                await Task.FromResult(
                    new AuthenticationState(
                        new ClaimsPrincipal(usuario)));
        }
    }
}
