using bluelotus.syncfprowasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using SyncfusionBlazorApp1;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<BLMain>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF5cWWJCfEx3RHxbf1x0ZFBMYF5bRnBPMyBoS35RckViWH1edXRXRGdbUkZ3");

await builder.Build().RunAsync();
