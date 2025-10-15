using System.Text.Json.Serialization;

namespace Bingo.Models;

public record Template(
    string Id,
    string Name,
    [property: JsonPropertyName("grp")] string Group,
    DateTime Creation,
    bool Imported);