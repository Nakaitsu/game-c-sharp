using System;
using GameCsharp.Entities;

namespace GameCsharp
{
  class Program
  {
    static void Update(Character[] allies, Character[] enemies)
    {
        Console.WriteLine("Allies:");
        foreach(var element in allies)
        {
          Console.WriteLine(element);
        }

        Console.WriteLine("Enemies Alive");
        foreach (var element in enemies)
        {
          Console.WriteLine(element);
        }
    }
    static void Main(string[] args)
    {
      Warrior hero = new Warrior("Arus", 12, "Long Sword");
      Wizard anna = new Wizard("anna", 15, "Ancient Staff");
      Bandit enemy1 = new Bandit("Boris", 21, "Dagger");

      Character[] allies = {hero, anna};
      Character[] enemies = {enemy1};

      Update(allies, enemies);
      hero.PierceAttack(enemy1);
      
    }
  }
}
