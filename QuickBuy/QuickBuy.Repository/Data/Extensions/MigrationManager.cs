using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace QuickBuy.Repository.Data.Extensions
{
    public static class MigrationManager
    {
        private const string DATABASE = "QuickBuy";

        public static IHost MigrateDataBase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var databaseService = scope.ServiceProvider.GetRequiredService<DatabaseManager>();
                var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

                databaseService.CreateDatabase(DATABASE);

                migrationService.ListMigrations();
                migrationService.MigrateUp();
            }

            return host;
        }
    }
}