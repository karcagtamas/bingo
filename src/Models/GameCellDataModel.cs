namespace Bingo.Models;

public record GameCellDataModel(string Id, int OrderNo, bool Checked, bool Joker, string? Caption, string GameId);