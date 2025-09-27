namespace Bingo.Tauri.Interface.FS.Models;

public record DirEntry(
    bool IsDirectory,
    bool IsFile,
    bool IsSymlink,
    string Name
);