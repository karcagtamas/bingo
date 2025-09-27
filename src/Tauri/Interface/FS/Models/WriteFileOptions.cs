namespace Bingo.Tauri.Interface.FS.Models;

public record WriteFileOptions(
    bool Append = false,
    BaseDirectory? BaseDir = null,
    bool? Create = null,
    bool? CreateNew = null,
    int? Mode = null
);