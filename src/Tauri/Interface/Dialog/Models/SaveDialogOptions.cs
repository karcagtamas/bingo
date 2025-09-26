namespace Bingo.Tauri.Interface.Dialog.Models;

public record SaveDialogOptions(string DefaultPath, List<DialogFilter> Filters, string? Title = null, bool? CanCreateDirectories = null);