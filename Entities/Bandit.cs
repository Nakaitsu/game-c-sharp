namespace GameCsharp.Entities
{
  class Bandit : Character
  {
    public Bandit(string Name, int Level, string Weapon)
    {
      this.Name = Name;
      this.Level = Level;
      this.ClassType = "Bandit";
      this.Weapon = Weapon;
      this.Atk += 20;
      this.Hp += 30;
      this.Mp += 30;
    }

      public Bandit(){}
  }
}