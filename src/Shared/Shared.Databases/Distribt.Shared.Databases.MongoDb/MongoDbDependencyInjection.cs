using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Distribt.Shared.Databases.MongoDb;

public static class MongoDbDependencyInjection
{
    public static IServiceCollection AddMongoDbConnectionProvider(this IServiceCollection serviceCollection)
    {
        var conventionPack = new ConventionPack { new IgnoreExtraElementsConvention(true) };
        ConventionRegistry.Register("IgnoreExtraElements", conventionPack, type => true);
        
        return serviceCollection.AddScoped<IMongoDbConnectionProvider, MongoDbConnectionProvider>(); 
    }
    
    public static IServiceCollection AddMongoDbDatabaseConfiguration(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<DatabaseConfiguration>(configuration.GetSection("Database:MongoDb"));
        return serviceCollection;
    }
    
}

//nullables are a pain in the ass for the configuration files
public class DatabaseConfiguration
{
    public string DatabaseName { get; set; } = default!;
}

public class MongoEventStoreConfiguration
{
    public string DatabaseName { get; set; } = default!;
    public string CollectionName { get; set; } = default!;
}



