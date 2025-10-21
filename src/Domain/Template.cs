using System.Text.Json.Serialization;

namespace Bingo.Domain;

public record Template(
    string Id,
    string Name,
    [property: JsonPropertyName("grp")] string Group,
    DateTime Creation,
    bool Imported) : IEntity;