using GameCsharp.Entities;

namespace GameCsharp
{
  class Program
  {
    static void Main(string[] args)
    {     
      Hero mark = new Warrior("Mark");
      Hero emilia = new Wizard("Emilia");
      Enemy slime1 = new Slime("Green Slime", 1);

      Hero[] heroes = {mark, emilia};
      Enemy[] enemies = {slime1};

      Battle battle = new Battle(heroes, enemies);

      System.Console.WriteLine(mark);

    }
  }
}
