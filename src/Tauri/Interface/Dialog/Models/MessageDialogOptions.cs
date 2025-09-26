namespace Bingo.Tauri.Interface.Dialog.Models;

// Custom buttons is not supported yet
public record MessageDialogOptions(string? Title = null, Kind Kind = Kind.Info, string? OkLabel = null, MessageDialogOptions? Buttons = null)
{
    public enum MessageDialogDefaultButtons
    {
        Ok,
        OkCancel,
        YesNo,
        YesNoCancel,
    }
}