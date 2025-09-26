using Bingo.Tauri.Interface.Models;

namespace Bingo.Tauri.Interface;

public interface ITauriDialogInterop
{
    public Task ShowMessageAsync(string message, string? title = null);

    public Task<bool> AskAsync(string message, string? title = null);

    public Task<bool> ConfirmAsync(string message, string? title = null);

    public Task<string?> OpenFileAsync(OpenFileOptions options);

    public Task<string?> SaveFileAsync(SaveFileOptions options);
}