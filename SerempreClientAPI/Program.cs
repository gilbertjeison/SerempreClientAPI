using Microsoft.EntityFrameworkCore;
using SerempreClientAPI.Infrastructure.DataSource;
using SerempreClientAPI.Infrastructure.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(config.GetConnectionString("sqlServer"),
        x => x.MigrationsAssembly("SerempreClientAPI.Infrastructure"));
});

builder.Services.AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(Assembly.Load("SerempreClientAPI.Application")));

builder.Services.AddDomainServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");


app.Run();

