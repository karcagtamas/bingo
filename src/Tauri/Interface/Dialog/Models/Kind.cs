using System.Text.Json.Serialization;

namespace Bingo.Tauri.Interface.Dialog.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Kind
{
    [JsonStringEnumMemberName("info")]
    Info,
    
    [JsonStringEnumMemberName("warning")]
    Warning,
    
    [JsonStringEnumMemberName("error")]
    Error
}