using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestaurantBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Read API URL from appsettings.json
//var apiUrl = builder.Configuration["ApiBaseUrl"] ?? "http://localhost:5000/api";
// 1. Get URL from the config file (Development.json or appsettings.json)
var apiUrl = builder.Configuration["ApiBaseUrl"];

// 2. Fallback if config is missing
if (string.IsNullOrEmpty(apiUrl))
{
    // Fallback to the URL the app is served from (useful for self-hosted)
    apiUrl = builder.HostEnvironment.BaseAddress; 
}
// FIX: Ensure the API URL ends with a slash '/'
if (!apiUrl.EndsWith("/"))
{
    apiUrl += "/";
}

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

await builder.Build().RunAsync();