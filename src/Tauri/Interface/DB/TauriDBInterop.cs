using Bingo.Models;
using Bingo.Models.Games;
using Bingo.Models.Templates;
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

    public async Task<List<GameDataModel>> GetGamesAsync() =>
        await JSRuntime.InvokeAsync<List<GameDataModel>>("getGames");

    public async Task<GameDataModel?> GetGameAsync(string id) =>
        await JSRuntime.InvokeAsync<GameDataModel>("getGame", id);

    public async Task AddGameAsync(GameDataModel data) =>
        await JSRuntime.InvokeVoidAsync("addGame", data);

    public async Task UpdateGameAsync(GameDataModel data) =>
        await JSRuntime.InvokeVoidAsync("updateGame", data);

    public async Task DeleteGameAsync(string id) =>
        await JSRuntime.InvokeVoidAsync("deleteGame", id);
}