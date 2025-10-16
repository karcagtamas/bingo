using Bingo.Models;
using Microsoft.JSInterop;

namespace Bingo.Tauri.Interface.DB;

public class TauriDBInterop(IJSRuntime jsRuntime) : AbstractInterop(jsRuntime), ITauriDBInterop
{
    public async Task<List<Template>> GetTemplatesAsync() =>
        await JSRuntime.InvokeAsync<List<Template>>("getTemplates");

    public async Task<Template?> GetTemplateAsync(string id) =>
        await JSRuntime.InvokeAsync<Template>("getTemplate", id);

    public async Task AddTemplateAsync(Template data) =>
        await JSRuntime.InvokeVoidAsync("addTemplate", data);

    public async Task UpdateTemplateAsync(Template data) =>
        await JSRuntime.InvokeVoidAsync("updateTemplate", data);

    public async Task DeleteTemplateAsync(string id) =>
        await JSRuntime.InvokeVoidAsync("deleteTemplate", id);

    public async Task<List<Game>> GetGamesAsync() =>
        await JSRuntime.InvokeAsync<List<Game>>("getGames");

    public async Task<Game?> GetGameAsync(string id) =>
        await JSRuntime.InvokeAsync<Game>("getGame", id);

    public async Task AddGameAsync(Game data) =>
        await JSRuntime.InvokeVoidAsync("addGame", data);

    public async Task UpdateGameAsync(Game data) =>
        await JSRuntime.InvokeVoidAsync("updateGame", data);

    public async Task DeleteGameAsync(string id) =>
        await JSRuntime.InvokeVoidAsync("deleteGame", id);
}