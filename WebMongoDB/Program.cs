using WebMongoDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebMongoDB.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebMongoDBContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("WebMongoDBContext")));

ContextoMongodb.ConnectionString = builder.Configuration.GetSection("MongoConnection:ConnectionString").Value;
ContextoMongodb.DatabaseName = builder.Configuration.GetSection("MongoConnection:Database").Value;

ContextoMongodb.IsSSL = Convert.ToBoolean(builder.Configuration.GetSection("MongoConnection:IsSSL").Value);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
