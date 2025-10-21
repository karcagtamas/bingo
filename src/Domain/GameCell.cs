namespace Bingo.Domain;

public record GameCell(string Id, int OrderNo, bool Checked, bool Joker, string? Caption, string GameId): IEntity;