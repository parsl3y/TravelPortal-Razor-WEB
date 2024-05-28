using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TravelPortalBlazor.Service.Services.CityService;
using TravelPortalBlazor.Service.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
builder.Services.AddScoped<ICityService, ClientCityService>();

await builder.Build().RunAsync();

