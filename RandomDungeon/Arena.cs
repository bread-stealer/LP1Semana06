using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy>value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            // CÓDIGO AQUI
            List<string> names = new List<string>();
foreach (Enemy e in enemies)
{
    names.Add(e.GetName());
}
Console.WriteLine("Arena: " + string.Join(", ", names));
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            // Subtrai o Ataque do Atacante à Vida do Defensor
            // Garante que a Vida Não Fique Negativa
            // CÓDIGO AQUI
            int newHealth = defender.GetHealth() - attacker.GetAttack();
            defender.SetHealth(Math.Max(0, newHealth));
            
            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            // CÓDIGO AQUI
            if (defender.GetHealth() == 0)
            {
                enemies.Remove(defender);
            }
        }
    }
}