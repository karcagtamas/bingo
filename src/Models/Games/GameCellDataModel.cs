namespace Bingo.Models.Games;

public record GameCellDataModel(string Id, int OrderNo, bool Checked, bool Joker, string? Caption, string GameId);