using Distribt.Shared.Databases.MongoDb;
using Microsoft.Extensions.Configuration;

namespace Distribt.Shared.Setup.Databases;

public static class MongoDb
{
    public static IServiceCollection AddDistribtMongoDbConnectionProvider(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        return serviceCollection
            .AddMongoDbConnectionProvider()
            .AddMongoDbDatabaseConfiguration(configuration);
    }
}