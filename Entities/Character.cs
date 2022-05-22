using GameCsharp.Interfaces;
using System.Collections.Generic;

namespace GameCsharp.Entities
{
  public abstract class Character : ICharacter
  {
    public string? Name { get; set; }
    public int Level { get; set; } = 0;
    public int Health { get; set; }
    public int Strength { get; set; }

    // public List<Skill> Skills { get; set; }

    public override string ToString()
    {
      var info = 
      @$"
      --------------------------------
      Name: {this.Name}
      Health: {this.Health}
      Strength: {this.Strength}
      --------------------------------";

      return info.Trim(' ');
    }

    public virtual void Attack(Character target)
    {
      Console.WriteLine($"{this.Name} Disparou um ataque contra {target.Name}");

      if (target.Health <= this.Strength)
      {
        target.Health = 0;
      }
      else
      {
        target.Health -= this.Strength;
        int dano = target.Health -= this.Strength;
        Console.WriteLine($"{target.Name} sofreu {dano} de dano");
      }
    }

  }
}