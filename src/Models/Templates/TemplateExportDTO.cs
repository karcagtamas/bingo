namespace Bingo.Models.Templates;

public record TemplateExportDTO(string Id, string Name, string Group, List<TemplateItemExportDTO> Items);