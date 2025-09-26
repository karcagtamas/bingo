using Bingo.Tauri.Interface.Dialog.Models;

namespace Bingo.Tauri.Interface.Dialog;

public interface ITauriDialogInterop
{
    public Task<MessageDialogResult> ShowMessageAsync(string message, MessageDialogOptions options);

    public Task<bool> AskAsync(string message, ConfirmDialogOptions options);

    public Task<bool> ConfirmAsync(string message, ConfirmDialogOptions options);

    public Task<string?> OpenFileAsync(OpenDialogOptions options);

    public Task<string?> SaveFileAsync(SaveDialogOptions options);
}