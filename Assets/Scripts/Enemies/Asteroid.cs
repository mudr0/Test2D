using UnityEngine;

namespace Rocket
{
    public class Asteroid : Enemy
    {
        public override void Move()
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);
        }
    }
}
