using UnityEngine;

namespace Rocket
{
    public class Gun
    {
        private Sprite _bulletSprite;
        private Transform _barrel;
        private float _force;

        public Gun(Sprite bulletSprite, Transform barrel, float force)
        {
            _barrel = barrel;
            _force = force;
            _bulletSprite = bulletSprite;
        }

        public void Shoot()
        {
            var builder = new GameObjectBuilder();
            var tempAmmunition = builder
                .Visual
                .Name("Bullet")
                .Sprite(_bulletSprite)
                .Position(_barrel.position)
                .Physics
                .RigidBody2D(0, _force *_barrel.up)
                .BoxCollider2D();
        }
    }
}
