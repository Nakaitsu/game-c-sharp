namespace GameCsharp.Entities
{
  public class Hero : Character
  {
    public readonly bool OwnedByPlayer = true;
    private int experience;
    public int Mp { get; set; }
    public Equip? Hand { get; set; }
    public Equip? OffHand { get; set; }

    public Hero()
    {
      this.experience = 0;
    }

    public int Experience
    {
      get
      {
        return this.experience;
      }

      set
      {
        this.experience = value;

        if (this.experience >= 100)
        {
          this.experience -= 100;
          ++this.Level;

          Console.WriteLine($"{this.Name} aumentou de level");
        }
      }
    }

    public override string ToString()
    {
      return "======================================================================\n" + 
            $"|Name: {this.Name}  |Level: {this.Level}  |Health: {this.Health}  |MP: {this.Mp}  |Strength: {this.Strength}  |XP: {this.Experience}  |\n" +
             "======================================================================\n";
    }
  }
}