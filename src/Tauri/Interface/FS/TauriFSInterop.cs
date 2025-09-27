using Bingo.Tauri.Interface.FS.Models;
using Microsoft.JSInterop;
using FileInfo = Bingo.Tauri.Interface.FS.Models.FileInfo;

namespace Bingo.Tauri.Interface.FS;

public class TauriFSInterop(IJSRuntime jsRuntime) : AbstractInterop(jsRuntime), ITauriFSInterop
{
    public async Task CopyFileAsync(string fromPath, string toPath, CopyFileOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}copyFile", fromPath, toPath, options);

    public async Task CreateAsync(string path, CreateOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}create", path, options);

    public async Task<bool> ExistsAsync(string path, ExistsOptions options) =>
        await JSRuntime.InvokeAsync<bool>($"{ScriptPrefix}exists", path, options);

    public async Task<FileInfo> LstatAsync(string path, StatOptions options) =>
        await JSRuntime.InvokeAsync<FileInfo>($"{ScriptPrefix}lstat", path, options);

    public async Task MkdirAsync(string path, MkdirOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}mkdir", path, options);

    public async Task OpenAsync(string path, OpenOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}open", path, options);

    public async Task<List<DirEntry>> ReadDirAsync(string path, ReadDirOptions options) =>
        await JSRuntime.InvokeAsync<List<DirEntry>>($"{ScriptPrefix}readDir", path, options);

    public async Task<byte[]> ReadFileAsync(string path, ReadFileOptions options) =>
        await JSRuntime.InvokeAsync<byte[]>($"{ScriptPrefix}readFile", path, options);

    public async Task<string> ReadTextFileAsync(string path, ReadFileOptions options) =>
        await JSRuntime.InvokeAsync<string>($"{ScriptPrefix}readFile", path, options);

    public async Task<string[]> ReadTextFileLinesAsync(string path, ReadFileOptions options) =>
        await JSRuntime.InvokeAsync<string[]>($"{ScriptPrefix}readFile", path, options);

    public async Task RemoveAsync(string path, RemoveOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}remove", path, options);

    public async Task RenameAsync(string oldPath, string newPath, RenameOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}rename", oldPath, newPath, options);

    public async Task<int> SizeAsync(string path) =>
        await JSRuntime.InvokeAsync<int>($"{ScriptPrefix}size", path);

    public async Task<FileInfo> StatAsync(string path, StatOptions options) =>
        await JSRuntime.InvokeAsync<FileInfo>($"{ScriptPrefix}stat", path, options);

    public async Task TruncateAsync(string path, int? len, TruncateOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}truncate", path, len, options);

    public async Task WriteFileAsync(string path, byte[] data, WriteFileOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}writeFile", path, data, options);

    public async Task WriteTextFileAsync(string path, string data, WriteFileOptions options) =>
        await JSRuntime.InvokeVoidAsync($"{ScriptPrefix}writeTextFile", path, data, options);
}