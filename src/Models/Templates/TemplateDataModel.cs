using System.Text.Json.Serialization;

namespace Bingo.Models.Templates;

public record TemplateDataModel(
    string Id,
    string Name,
    [property: JsonPropertyName("grp")] string Group,
    DateTime Creation,
    bool Imported,
    List<TemplateItemDataModel> Items);