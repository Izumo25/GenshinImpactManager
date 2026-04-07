namespace GenshinImpactManager.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Element { get; set; } = string.Empty;
    public int Rarity { get; set; }  // 4 или 5 звезд
}