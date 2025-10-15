using System.ComponentModel.DataAnnotations;

namespace Bingo.Models;

public class TemplateModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required] public string? Name { get; set; }

    [Required] public string? Group { get; set; }
}