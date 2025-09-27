namespace Bingo.Tauri.Interface.FS.Models;

public record FileInfo(
    DateTime? Atime,
    DateTime? Birthtime,
    int? Blksize,
    int? Blocks,
    int? Dev,
    int? FileAttributes,
    int? Gid,
    int? Ino,
    bool IsDirectory,
    bool IsFile,
    bool IsSymlink,
    int? Mode,
    DateTime? Mtime,
    int? Nlink,
    int? Rdev,
    bool Readonly,
    int Size,
    int? Uid
);