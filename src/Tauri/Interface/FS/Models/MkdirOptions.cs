namespace Bingo.Tauri.Interface.FS.Models;

public record MkdirOptions(BaseDirectory? BaseDir, int Mode = 511, bool Recursive = false);