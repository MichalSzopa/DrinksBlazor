using DrinksWebApp.Data;
using DrinksWebApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
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
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
options =>
{
    // Sposob aby zwrocic kod 401 (Unauthorized) zamiast 404 (NotFound)
    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.Headers["Location"] =
        context.RedirectUri;
        context.Response.StatusCode = 401;
        return Task.CompletedTask;
    };
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
