namespace Bingo.Tauri.Interface.Dialog.Models;

public record ConfirmDialogOptions(string? Title = null, Kind Kind = Kind.Info, string? OkLabel = null, string? CancelLabel = null);