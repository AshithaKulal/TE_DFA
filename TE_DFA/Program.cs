using Microsoft.EntityFrameworkCore;
using TE_DFA.Models;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// NToastNotify
builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
{
    ProgressBar = true,
    Timeout = 3000 //5 seconds
});

// Add services to the container.
builder.Services.AddControllersWithViews();

//configure Database connection string
builder.Services.AddDbContext<Dotnet_CoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
