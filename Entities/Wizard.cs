namespace GameCsharp.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name)
        {
            this.Name = Name;
            base.Health = 20;
            base.Mp = 30;
            base.Strength = 12;
        }

        public void ConjurarMagiaDeFogo(Character target)
        {
            int custo = 10;
            float poder = this.Strength * 1.2f;

            if(this.Mp < custo )
            {
                Console.WriteLine("Mana insuficiente para conjurar magia");
                return;
            }

            this.Mp -= custo;

            if(target.Health <= (int)poder)
            {
                target.Health = 0;
            } 
            else
            {
                target.Health -= (int)poder;
                Console.WriteLine($"{target.Name} sofreu {(int)poder} de dano");
            }
        }

    }
}