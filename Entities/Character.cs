using GameCsharp.Interfaces;

namespace GameCsharp.Entities
{
    public abstract class Character : ICharacter
    {
        public string Name { get; set; }
        public int Level { get; set; } = 0;
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Mp { get; set;}

        public override string ToString()
        {
            return $"Name: {this.Name}| Level: {this.Level}| HP: {this.Hp}| MP: {this.Mp}| ATK: {this.Atk}";
        }

        public virtual void Attack(Character target)
        {
            Console.WriteLine($"{this.Name} Disparou um ataque contra {target.Name}");

            if(target.Hp <= this.Atk)
            {
                target.Hp = 0;
            } 
            else
            {
                target.Hp -= this.Atk;
                int dano = target.Hp -= this.Atk;
                Console.WriteLine($"{target.Name} sofreu {dano} de dano");
            }
        }

    }
}