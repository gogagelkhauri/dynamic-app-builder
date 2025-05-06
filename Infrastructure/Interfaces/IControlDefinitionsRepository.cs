using Shared;

namespace Infrastructure.Interfaces;

public interface IControlDefinitionsRepository
{
    Task AddAsync(ControlDefinitionGroup entity);
    Task<List<ControlDefinitionGroup>> GetAllAsync();
}