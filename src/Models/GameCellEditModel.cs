namespace Bingo.Models;

public class GameCellEditModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public int OrderNo { get; set; }

    public bool Checked { get; set; }

    public bool Joker { get; set; }

    public string? Caption { get; set; }
}