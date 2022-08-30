using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rocket
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] protected float Speed;
        public Health Health;

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public abstract void Move();
        
        

        private void Update()
        {
            Move();
        }
    }
}