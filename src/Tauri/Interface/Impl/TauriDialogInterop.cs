using Bingo.Tauri.Interface.Models;
using Microsoft.JSInterop;

namespace Bingo.Tauri.Interface.Impl;

public class TauriDialogInterop(IJSRuntime jsRuntime) : AbstractInterop(jsRuntime), ITauriDialogInterop
{
    public async Task ShowMessageAsync(string message, string? title = null) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}showMessage", message, title ?? "Info");

    public async Task<bool> AskAsync(string message, string? title = null) =>
        await JSRuntime.InvokeAsync<bool>($"{ScriptPrefix}ask", message, title ?? "Confirm");

    public async Task<bool> ConfirmAsync(string message, string? title = null) =>
        await JSRuntime.InvokeAsync<bool>($"{ScriptPrefix}confirm", message, title ?? "Confirm");

    public async Task<string?> OpenFileAsync(OpenFileOptions options) =>
        await JSRuntime.InvokeAsync<string?>($"{ScriptPrefix}openFileDialog", options);

    public async Task<string?> SaveFileAsync(SaveFileOptions options) =>
        await JSRuntime.InvokeAsync<string?>($"{ScriptPrefix}saveFileDialog", options);
}