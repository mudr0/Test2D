using UnityEngine;

namespace Rocket
{
    public interface IEnemyFactory
    {
        public Enemy CreateEnemy(Health hp);
    }
}
