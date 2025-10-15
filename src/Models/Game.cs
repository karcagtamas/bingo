namespace Bingo.Models;

public record Game(string Id, string Caption, string? TemplateId, bool Custom, int Rows, int Cols, DateTime Creation);