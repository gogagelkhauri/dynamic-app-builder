using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Shared;

namespace Infrastructure;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;
    
    public MongoDbContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
        _database = client.GetDatabase(configuration["MongoDbSettings:DynamicAppBuilder"]);
    }
    
    public IMongoCollection<ControlDefinitionGroup> ControlDefinitionGroups => _database.GetCollection<ControlDefinitionGroup>("ControlDefinitionGroups");

}