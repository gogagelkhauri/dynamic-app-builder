using Infrastructure.Interfaces;
using MongoDB.Driver;
using Shared;

namespace Infrastructure.Repositories;

public class ControlDefinitionsRepository : IControlDefinitionsRepository
{
    private readonly MongoDbContext _context;

    public ControlDefinitionsRepository(MongoDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<ControlDefinitionGroup>> GetAllAsync() =>
        await _context.ControlDefinitionGroups.Find(_ => true).ToListAsync();
    
    
    
    public async Task AddAsync(ControlDefinitionGroup entity)
    {
        await _context.ControlDefinitionGroups.InsertOneAsync(entity);
    }
}