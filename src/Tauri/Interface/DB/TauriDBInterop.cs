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
}