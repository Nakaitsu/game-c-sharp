namespace GameCsharp.Entities
{
    public class Wizard : Character
    {
      public Wizard(string Name, int Level, string Weapon)
      {
        this.Name = Name;
        this.Level = Level;
        this.Weapon = Weapon;
        this.ClassType = "wizard";
        this.Atk += 25;
        this.Hp += 25;
        this.Mp += 100;
      }

      public Wizard(){}

      public void Heal()
      {
        this.Mp -= 20;
        this.Hp += 20;
        Console.WriteLine(this.Name + " se curou");
      }
      public void Heal(Character target)
      {
        this.Mp -= 20;
        Console.WriteLine($"{this.Name} curou {target.Name}");
        
        target.Hp += 20;
        Console.WriteLine($"{target.Name} recuperou 20 HP");
      }

      public void FireBall(Character target)
      {
        this.Mp -= 30;
        Console.WriteLine($"{this.Name} conjurou Bola de Fogo!");
        
        target.Hp -= 55;
        Console.WriteLine($"{target.Name} sofreu 50 de Dano");
      }
      
    }
}