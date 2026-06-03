using EvolveDb;
using Microsoft.Data.SqlClient;

namespace RestWithASPNET10Course.Configurations
{
    public static class EvolveConfig
    {
        public static IServiceCollection AddEvolveConfiguration(
            this IServiceCollection services, 
            IConfiguration configuration,
            IWebHostEnvironment environment)
        {
            if(environment.IsDevelopment())
            {
                var connectionString = configuration[
                    "MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception(
                        "Connection string for MSSQL Server SQL is not configured.");
                }
                try
                {
                    using var evolveConnection = new SqlConnection(connectionString);
                    var evolve = new Evolve(
                        evolveConnection,
                        msg => Console.WriteLine(msg))
                    {
                        Locations = new List<string> { "db/migrations", "db/dataset" },
                        IsEraseDisabled = true
                    };
                    evolve.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
            return services;
        }
    }
}
