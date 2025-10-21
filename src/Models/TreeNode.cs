namespace Bingo.Models;

public class TreeNode(object data)
{
    public object Data { get; init; } = data;

    public string Name { get; set; } = string.Empty;
    public bool IsExpanded { get; set; }
    public int Level { get; set; } = 0;
    public List<TreeNode> Children { get; set; } = [];
}