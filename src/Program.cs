using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Bingo;
using Bingo.Tauri.Interface.DB;
using Bingo.Tauri.Interface.Dialog;
using Bingo.Tauri.Interface.FS;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITauriDialogInterop, TauriDialogInterop>();
builder.Services.AddScoped<ITauriFSInterop, TauriFSInterop>();
builder.Services.AddScoped<ITauriDBInterop, TauriDBInterop>();
builder.Services.AddFluentUIComponents();

#if DEBUG
builder.Services.AddSassCompiler();
#endif

await builder.Build().RunAsync();