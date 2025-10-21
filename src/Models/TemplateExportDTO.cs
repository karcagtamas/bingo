namespace Bingo.Models;

public record TemplateExportDTO(string Id, string Name, string Group, List<TemplateItemExportDTO> Items);