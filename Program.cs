using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TodoApplikasjonenDelTre;
using TodoApplikasjonenDelTre.Pages;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<TodoService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthService>();


await builder.Build().RunAsync();

