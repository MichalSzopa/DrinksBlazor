using DrinksWebApp.Auth;
using DrinksWebApp.Data;
using DrinksWebApp.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Extensions.Options;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSyncfusionBlazor();
builder.Services.AddDbContext<DrinksAppContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IngredientService>();
builder.Services.AddSingleton<AlcoholIngredientService>();
builder.Services.AddSingleton<DrinkService>();
builder.Services.AddSingleton<OpinionService>();
builder.Services.AddSingleton<UserService>();

// auth
builder.Services.AddAuthenticationCore();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
var configuration = builder.Configuration;

builder.Services.AddAuthentication().AddFacebook(facebookOptions =>
{
    facebookOptions.AppId = configuration["Authentication:Facebook:AppId"];
    facebookOptions.AppSecret = configuration["Authentication:Facebook:AppSecret"];
    facebookOptions.AccessDeniedPath = "/";
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

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
