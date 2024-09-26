using AccidentesTransitoApp.Client;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AccidenteService>();


await builder.Build().RunAsync();

