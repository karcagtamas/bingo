namespace Bingo.Tauri.Interface.Dialog.Models;

public record OpenDialogOptions(
    string DefaultPath,
    List<DialogFilter> Filters,
    string? Title = null,
    bool? CanCreateDirectories = null,
    string? Directory = null,
    bool? Multiple = null,
    bool? Recursive = null
);