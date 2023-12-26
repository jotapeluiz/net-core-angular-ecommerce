using System.Reflection;
using FluentMigrator.Runner;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Data;
using QuickBuy.Repository.Data.Migrations;
using QuickBuy.Repository.Data.Extensions;
using QuickBuy.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<DatabaseManager>();
builder.Services.AddSingleton<IDapperContext, DapperContext>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

var databaseConnection = builder.Configuration.GetConnectionString("DatabaseApp");
var assemblyMigrations = Assembly.GetAssembly(typeof(DatabaseManager));

builder.Services.AddLogging(c => c.AddFluentMigratorConsole())
        .AddFluentMigratorCore()
        .ConfigureRunner(cr => cr.AddPostgres()
            .WithGlobalConnectionString(databaseConnection)
            .ScanIn(assemblyMigrations).For.Migrations());

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MigrateDataBase();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}"
);

app.MapFallbackToFile("index.html");
app.Run();
