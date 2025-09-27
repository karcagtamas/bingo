namespace Bingo.Tauri.Interface.FS.Models;

public record RemoveOptions(
    BaseDirectory? BaseDir,
    bool Recursive = false
);