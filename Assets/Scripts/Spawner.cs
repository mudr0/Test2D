using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private float _delay;
        private IEnemyFactory _enemyFactory;
        private float _time;

        private void Awake()
        {
            _enemyFactory = new AsteroidFactory();
        }

        private void Update()
        {
            _time += Time.deltaTime;
            if (_time > _delay)
            {
                _enemyFactory.CreateEnemy(new Health(2, 2));
                _time = 0;
                Debug.Log("1");
            }
        }
    }
}
