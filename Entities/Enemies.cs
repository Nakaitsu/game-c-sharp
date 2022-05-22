namespace GameCsharp.Entities
{
  public class Slime : Enemy
  {
    public Slime(string Name, int Level = 1)
    {
      this.Name = Name;
      this.Level = Level;
      this.Health = 37;
      this.Strength = 8;
    }

    public override void SpecialAbility(Hero target) 
    {
      Console.WriteLine($"{this.Name} pulou em {target.Name}");
    }
  }

  public class GiantSlime : Enemy
  {
    public GiantSlime(string Name, int Level = 1)
    {
      this.Name = Name;
      this.Level = Level;
      this.Health = 65;
      this.Strength = 12;
    }
  }
}