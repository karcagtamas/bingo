namespace Bingo.Models;

public class TemplateItemEditModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string? Caption { get; set; }
}