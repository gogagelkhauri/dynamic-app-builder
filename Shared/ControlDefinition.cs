namespace Shared;

public class ControlDefinition
{
    public string Type { get; set; }
    public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
    public double PositionX { get; set; }
    public double PositionY { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString(); 
}
