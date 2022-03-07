namespace GameCsharp.Entities
{
  public class Warrior : Character
  {
    public Warrior(string Name, int Level, string Weapon)
    {
      this.Name = Name;
      this.Level = Level;
      this.ClassType = "Warrior";
      this.Weapon = Weapon;
      this.Atk += 35;
      this.Hp += 70;
      this.Mp += 20;
    }

    public Warrior(){}

    public void PierceAttack(Character target)
    {
      this.Mp -= 10;
      Console.WriteLine($"{this.Name} usou o Pierce Attack!");
      target.Hp = target.Hp - (this.Atk + 15);
      Console.WriteLine($"{target.Name} sofreu {this.Atk + 15} de dano");
    }

  }
}