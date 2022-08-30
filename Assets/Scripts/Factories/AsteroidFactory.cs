using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket
{
    public class AsteroidFactory : IEnemyFactory
    {
        public Enemy CreateEnemy(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }
    }
}
