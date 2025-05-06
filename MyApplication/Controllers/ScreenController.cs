using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace MyApplication.Controllers;

[ApiController]
[Route("api/screen")]
public class ScreenController : ControllerBase
{
    private readonly IControlDefinitionsRepository _controlDefinitionsRepository;

    public ScreenController(IControlDefinitionsRepository controlDefinitionsRepository)
    {
        _controlDefinitionsRepository = controlDefinitionsRepository;
    }

    [HttpPost("save-data")]
    public async Task<IActionResult> SaveData([FromBody] List<ControlDefinition> request)
    {
        var controlDefinitionGroup = new ControlDefinitionGroup()
        {
            Name = Guid.NewGuid().ToString(),
            ControlDefinitions = request
        };
        await _controlDefinitionsRepository.AddAsync(controlDefinitionGroup);
        return Ok();
    }

    [HttpGet("get-data")]
    public async Task<IActionResult> GetData() =>
    Ok(await _controlDefinitionsRepository.GetAllAsync());
}