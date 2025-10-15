using Bingo.Tauri.Interface.FS.Models;
using FileInfo = Bingo.Tauri.Interface.FS.Models.FileInfo;

namespace Bingo.Tauri.Interface.FS;

public interface ITauriFSInterop
{
    public Task CopyFileAsync(string fromPath, string toPath, CopyFileOptions options);

    public Task CreateAsync(string path, CreateOptions options);

    public Task<bool> ExistsAsync(string path, ExistsOptions options);

    public Task<FileInfo> LstatAsync(string path, StatOptions options);

    public Task MkdirAsync(string path, MkdirOptions options);

    public Task OpenAsync(string path, OpenOptions options);

    public Task<List<DirEntry>> ReadDirAsync(string path, ReadDirOptions options);

    public Task<byte[]> ReadFileAsync(string path, ReadFileOptions options);

    public Task<string?> ReadTextFileAsync(string path, ReadFileOptions options);

    public Task<string[]> ReadTextFileLinesAsync(string path, ReadFileOptions options);

    public Task RemoveAsync(string path, RemoveOptions options);

    public Task RenameAsync(string oldPath, string newPath, RenameOptions options);

    public Task<int> SizeAsync(string path);

    public Task<FileInfo> StatAsync(string path, StatOptions options);

    public Task TruncateAsync(string path, int? len, TruncateOptions options);

    public Task WriteFileAsync(string path, byte[] data, WriteFileOptions options);

    public Task WriteTextFileAsync(string path, string data, WriteFileOptions options);
}