using System.ComponentModel.DataAnnotations;

namespace Bingo.Models.Templates;

public class TemplateEditModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required] public string? Name { get; set; }

    [Required] public string? Group { get; set; }

    public List<TemplateItemEditModel> Items { get; set; } = [];
}