using Bingo.Models;

namespace Bingo.Mappers;

public static class TemplateMappers
{
    public static TemplateExportDTO ToExportDTO(this TemplateDataModel template) =>
        new(template.Id, template.Name, template.Group,
            template.Items.Select(item => item.ToExportDTO()).ToList());

    public static TemplateItemExportDTO ToExportDTO(this TemplateItemDataModel templateItem) =>
        new(templateItem.Id, templateItem.Caption);

    public static TemplateDataModel ToDataModel(this TemplateExportDTO dto, DateTime creation)
    {
        return new TemplateDataModel(dto.Id, dto.Name, dto.Group, creation, true,
            dto.Items.Select(item => item.ToDataModel(dto.Id)).ToList());
    }

    public static TemplateItemDataModel ToDataModel(this TemplateItemExportDTO dto, string templateId)
    {
        return new TemplateItemDataModel(dto.Id, dto.Caption, templateId);
    }
}