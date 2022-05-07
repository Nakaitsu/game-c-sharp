using System;
using GameCsharp.Entities;

namespace GameCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
        Warrior john = new Warrior("john");
        Warrior blake = new Warrior("Blake");
        Wizard zoe = new Wizard("Zoe");

        Console.WriteLine(john);
        Console.WriteLine(zoe);

        john.Attack(zoe);
        john.Experience += 70;
        Console.WriteLine(john.Experience);

        john.Experience += 21;
        john.Experience += 21;
        Console.WriteLine(john.Experience);
    }
  }
}
