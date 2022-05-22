namespace GameCsharp.Entities
{
    public abstract class Enemy : Character
    {
      public virtual void SpecialAbility() {}
      public virtual void SpecialAbility(Hero x) {}
    }
}