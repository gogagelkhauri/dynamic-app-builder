namespace MyApplication.Client.Models;

public class CanvasControl
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string ControlType { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Placeholder { get; set; } = string.Empty;
    public string DefaultValue { get; set; } = string.Empty;
    public int Top { get; set; } = 0;
    public int Left { get; set; } = 0;
    public List<string> Options { get; set; } = new();
    public bool IsRequired { get; set; } = false;
    public string ViewMode { get; set; } = "Desktop";
}