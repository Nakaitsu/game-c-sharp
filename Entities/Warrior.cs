namespace GameCsharp.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string Name)
        {
            this.Name = Name;
            base.Hp = 35;
            base.Mp = 12;
            base.Atk = 22;
        }

    }
}