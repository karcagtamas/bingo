using System.Text.Json.Serialization;

namespace Bingo.Models;

public record TemplateDataModel(
    string Id,
    string Name,
    [property: JsonPropertyName("grp")] string Group,
    DateTime Creation,
    bool Imported,
    List<TemplateItemDataModel> Items);