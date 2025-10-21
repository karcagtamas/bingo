using Bingo.Domain;
using Bingo.Models;
using Microsoft.JSInterop;

namespace Bingo.Tauri.Interface.DB;

public class TauriDBInterop(IJSRuntime jsRuntime) : AbstractInterop(jsRuntime), ITauriDBInterop
{
    public async Task<List<TemplateDataModel>> GetTemplatesAsync() =>
        await JSRuntime.InvokeAsync<List<TemplateDataModel>>("getTemplates");

    public async Task<TemplateDataModel?> GetTemplateAsync(string id) =>
        await JSRuntime.InvokeAsync<TemplateDataModel>("getTemplate", id);

    public async Task AddTemplateAsync(TemplateDataModel data) =>
        await JSRuntime.InvokeVoidAsync("addTemplate", data);

    public async Task UpdateTemplateAsync(TemplateDataModel data) =>
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