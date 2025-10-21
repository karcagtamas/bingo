using Bingo.Domain;
using Bingo.Models;

namespace Bingo.Tauri.Interface.DB;

public interface ITauriDBInterop
{
    public Task<List<TemplateDataModel>> GetTemplatesAsync();

    public Task<TemplateDataModel?> GetTemplateAsync(string id);

    public Task AddTemplateAsync(TemplateDataModel data);

    public Task UpdateTemplateAsync(TemplateDataModel data);

    public Task DeleteTemplateAsync(string id);
    
    public Task<List<Game>> GetGamesAsync();

    public Task<Game?> GetGameAsync(string id);

    public Task AddGameAsync(Game data);

    public Task UpdateGameAsync(Game data);

    public Task DeleteGameAsync(string id);
}