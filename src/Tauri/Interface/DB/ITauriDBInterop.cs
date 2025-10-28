using Bingo.Models;

namespace Bingo.Tauri.Interface.DB;

public interface ITauriDBInterop
{
    public Task<List<TemplateDataModel>> GetTemplatesAsync();

    public Task<TemplateDataModel?> GetTemplateAsync(string id);

    public Task AddTemplateAsync(TemplateDataModel data);

    public Task UpdateTemplateAsync(TemplateDataModel data);

    public Task DeleteTemplateAsync(string id);

    public Task<List<GameDataModel>> GetGamesAsync();

    public Task<GameDataModel?> GetGameAsync(string id);

    public Task AddGameAsync(GameDataModel data);

    public Task UpdateGameAsync(GameDataModel data);

    public Task DeleteGameAsync(string id);
}