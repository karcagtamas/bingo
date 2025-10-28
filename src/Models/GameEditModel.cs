using System.ComponentModel.DataAnnotations;

namespace Bingo.Models;

public class GameEditModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required] public string? Caption { get; set; }

    [Required] public int? Rows { get; set; } = 5;

    [Required] public int? Cols { get; set; } = 5;

    [Required] public string? TemplateId { get; set; }

    public List<GameCellEditModel> Cells { get; set; } = [];
}