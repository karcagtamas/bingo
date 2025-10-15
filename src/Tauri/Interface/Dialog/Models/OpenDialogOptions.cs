namespace Bingo.Tauri.Interface.Dialog.Models;

public record OpenDialogOptions(
    string DefaultPath,
    List<DialogFilter> Filters,
    string? Title = null,
    bool CanCreateDirectories = false,
    bool Directory = false,
    bool Multiple = false,
    bool Recursive = false
);