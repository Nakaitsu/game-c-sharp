namespace GameCsharp.Entities
{
    public abstract class Character
    {

      public Character(string Name, int Level, string Weapon)
      {
        this.Name = Name;
        this.Level = Level;
        this.ClassType = "undefined";
        this.Weapon = Weapon;
      }

      public Character(){}
      
      public string Name;

      public int Level;

      public string ClassType;

      public string Weapon = "Hands";

      public int Atk = 10;

      public int Mp = 20;

      public int Hp = 100;

      //ToString serve escrever um objeto pela stdout
      public override string ToString(){
        return $"Name: {this.Name}| Level: {this.Level}| Class: {this.ClassType}| HP: {this.Hp}| MP: {this.Mp}| ATK: {this.Atk}\n";
      }

      public virtual string Attack(){
        return this.Name + " Atacou";
      }

      public virtual void Attack(Character target)
      {
        
        if (target.Hp <= this.Atk)
        {
          target.Hp = 0;
          Console.WriteLine($"{this.Name} derrotou {target.Name}");
        }
        
        target.Hp -= this.Atk;
        Console.WriteLine($"{target.Name} sofreu {this.Atk} de dano");
      }
    }
}