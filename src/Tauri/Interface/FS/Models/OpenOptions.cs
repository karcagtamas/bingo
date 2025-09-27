namespace Bingo.Tauri.Interface.FS.Models;

public record OpenOptions(
    bool? Append,
    BaseDirectory? BaseDir,
    bool? Create,
    bool? CreateNew = false,
    int? Mode = 666,
    bool? Read = null,
    bool? Truncate = null,
    bool? Write = null
);