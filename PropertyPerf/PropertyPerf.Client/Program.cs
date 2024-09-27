using Csla.Configuration;
using Marimer.Blazor.RenderMode.WebAssembly;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddCsla(_ => _
    .AddBlazorWebAssembly(o => o.SyncContextWithServer = false));

builder.Services.AddRenderModeDetection();

await builder.Build().RunAsync();
