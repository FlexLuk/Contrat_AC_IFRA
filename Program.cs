using Blazored.LocalStorage;
using Contrat_AC.AuthetificationState.Data;
using Contrat_AC.Controller.Autorisation;
using Contrat_AC.Controller.Client;
using Contrat_AC.Data.AuthetificationState;
using Contrat_AC.Models.Autorisation;
using Contrat_AC.Models.Client;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<ILoginControl, LoginControl>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<IAutorisationService, AutorisationService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddDbContext<AUTORISATIONContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("osiet_connection"));
});
builder.Services.AddDbContext<CLIENTContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("osiet_connection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();