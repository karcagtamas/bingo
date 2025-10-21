namespace Bingo.Domain;

public record TemplateItem(string Id, string Caption, string TemplateId) : IEntity;