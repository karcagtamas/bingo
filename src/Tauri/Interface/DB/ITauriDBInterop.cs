using Bingo.Models;

namespace Bingo.Tauri.Interface.DB;

public interface ITauriDBInterop
{
    public Task<List<Template>> GetTemplatesAsync();

    public Task<Template?> GetTemplateAsync(string id);

    public Task AddTemplateAsync(Template data);

    public Task UpdateTemplateAsync(Template data);

    public Task DeleteTemplateAsync(string id);
}