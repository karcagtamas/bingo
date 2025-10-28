namespace Bingo.Models.Games;

public record GameDataModel(
    string Id,
    string Caption,
    string? TemplateId,
    bool Custom,
    int Rows,
    int Cols,
    DateTime Creation,
    List<GameCellDataModel> Cells);