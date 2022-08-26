using UnityEngine;

namespace Rocket
{
    public class HealthManager 
    { 
        private float _hp;
        private GameObject _player;

        public HealthManager( float hp, GameObject go)
        {
            _hp = hp;
            _player = go;
        }

        public void TakeDamage()
        {
            if (_hp <= 0)
            {
                _player.SetActive(false);
            }
            else
            {
                _hp--;
            }
        }
    }
}