using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TravelPortalBlazor.Service.Services.CityService;
using TravelPortalBlazor.Service.Services;
using TravelPortalBlazor.Service.Services.HotelService;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
builder.Services.AddScoped<ICityService, ClientCityService>();
builder.Services.AddScoped<IHotelService, ClientHotelService>();

await builder.Build().RunAsync();

