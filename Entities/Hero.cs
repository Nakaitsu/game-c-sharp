namespace GameCsharp.Entities
{
    public class Hero : Character
    {
        private int experience;

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

                if(this.experience >= 100)
                {
                    this.experience -= 100;
                    ++this.Level;

                    Console.WriteLine($"{this.Name} aumentou de level");
                }
            } 
        }
    }
}