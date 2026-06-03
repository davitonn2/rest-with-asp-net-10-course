using Microsoft.EntityFrameworkCore;
using RestWithASPNET10Course.Model.Context;

namespace RestWithASPNET10Course.Configurations
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfiguration(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string for MSSQL Server SQL is not configured.");
            }
            services.AddDbContext<MSSQLCcontext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
