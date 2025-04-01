using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorFenceTemplate;
using BlazorFenceTemplate.Sheath;
using BlazorFenceTemplate.Whetstone;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });;

builder.Services.AddSingleton<Whetstones>();
builder.Services.AddSingleton<Sheaths>();

await builder.Build().RunAsync();