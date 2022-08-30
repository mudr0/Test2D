using UnityEngine;

namespace Rocket
{
    public class Gun
    {
        private Transform _barrel;
        private Rigidbody2D _bullet;
        private float _force;

        public Gun(Transform barrel, Rigidbody2D bullet, float force)
        {
            _barrel = barrel;
            _bullet = bullet;
            _force = force;
        }

        public void Shoot()
        {
            var temAmmunition = MonoBehaviour.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
    }
}
