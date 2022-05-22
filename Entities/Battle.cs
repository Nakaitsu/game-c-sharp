using System.Collections.Generic;

namespace GameCsharp.Entities
{

  public class Battle
  {
    private List<Hero> Heroes = new List<Hero>();
    private List<Enemy> Enemies = new List<Enemy>();
    public Queue<Character> Turn = new Queue<Character>();
    public bool PlayerTurn;
    public bool EnemyTurn;
    public bool Victory;
    public bool Defeat;

    public Battle(Hero[] heroes, Enemy[] enemies)
    {
      foreach (var hero in heroes)
      {
        UpdateHeroes(hero);
      }
      foreach (var enemy in enemies)
      {
        UpdateEnemies(enemy);
      }
    }

    public void UpdateHeroes(Hero hero)
    {
      Heroes.Add(hero);
    }

    public void UpdateEnemies(Enemy enemy)
    {
      Enemies.Add(enemy);
    }

    public string Conditions()
    {
      if (Heroes.Count == 0)
      {
        return "Derrota";
      }
      else if (Enemies.Count == 0)
      {
        return "Vitória";
      }
      else
      {
        return "Ainda em batalha";
      }
    }

    public void Update()
    {
      Heroes.RemoveAll(x => x.Health == 0);
      Enemies.RemoveAll(x => x.Health == 0);
    }
  }
}