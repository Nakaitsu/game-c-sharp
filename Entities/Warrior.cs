namespace GameCsharp.Entities
{
  public class Warrior : Hero
  {
    public Warrior(string Name)
    {
      this.Name = Name;
      base.Health = 35;
      base.Mp = 12;
      base.Strength = 20;
    }

  }
}