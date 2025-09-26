using Bingo.Tauri.Interface.Dialog.Models;
using Microsoft.JSInterop;

namespace Bingo.Tauri.Interface.Dialog;

public class TauriDialogInterop(IJSRuntime jsRuntime) : AbstractInterop(jsRuntime), ITauriDialogInterop
{
    public async Task<MessageDialogResult> ShowMessageAsync(string message, MessageDialogOptions options) =>
        await JSRuntime.InvokeAsync<MessageDialogResult>($"{ScriptPrefix}showMessage", message, options);

    public async Task<bool> AskAsync(string message, ConfirmDialogOptions options) =>
        await JSRuntime.InvokeAsync<bool>($"{ScriptPrefix}ask", message, options);

    public async Task<bool> ConfirmAsync(string message, ConfirmDialogOptions options) =>
        await JSRuntime.InvokeAsync<bool>($"{ScriptPrefix}confirm", message, options);

    public async Task<string?> OpenFileAsync(OpenDialogOptions options) =>
        await JSRuntime.InvokeAsync<string?>($"{ScriptPrefix}openFileDialog", options);

    public async Task<string?> SaveFileAsync(SaveDialogOptions options) =>
        await JSRuntime.InvokeAsync<string?>($"{ScriptPrefix}saveFileDialog", options);
}