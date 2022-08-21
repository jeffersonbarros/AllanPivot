using AllanPivot.Data;
using AllanPivot.Setups;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Register Syncfusion license
SyncfusionLicenseProvider.RegisterLicense("Njc0MDc0QDMyMzAyZTMyMmUzMHBFV21ncDZxeEE0YmlSbGhyTWRoSGZJak9ybk03NVRsclRHTVRDeWY3UEk9");

builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
//Register the Syncfusion locale service to localize Syncfusion Blazor components.
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
