using Microsoft.JSInterop;

namespace Bingo.Tauri;

public abstract class AbstractInterop(IJSRuntime jsRuntime)
{
    protected static readonly string ScriptPrefix = "tauri__";
    protected readonly IJSRuntime JSRuntime = jsRuntime;
}