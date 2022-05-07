namespace GameCsharp.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name)
        {
            this.Name = Name;
            base.Hp = 20;
            base.Mp = 30;
            base.Atk = 12;
        }

        public void ConjurarMagiaDeFogo(Character target)
        {
            int custo = 10;
            float poder = this.Atk * 1.2f;

            if(this.Mp < custo )
            {
                Console.WriteLine("Mana insuficiente para conjurar magia");
                return;
            }

            this.Mp -= custo;

            if(target.Hp <= (int)poder)
            {
                target.Hp = 0;
            } 
            else
            {
                target.Hp -= (int)poder;
                Console.WriteLine($"{target.Name} sofreu {(int)poder} de dano");
            }
        }

    }
}