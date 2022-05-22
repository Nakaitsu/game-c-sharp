using GameCsharp.Enums;

namespace GameCsharp.Entities
{
  public class Equip
  {
    public string? Name { get; set; }
    public int Damage { get; set; }
    public string Style { get; set; }
    public EquipModifier Modifier { get; set; }

    public Equip(string Name, int Damage, string Style, int Modifier)
    {
      this.Name = Name;
      this.Damage = Damage;
      this.Style = Style;
    }

    void foo()
    {
    }
  }
}