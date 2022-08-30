using UnityEngine;

namespace Rocket
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        private MoveTransform _moveTransform;
        private HealthManager _healthManager;
        private Gun _gun;

        private void Awake()
        {
            _healthManager = new HealthManager( _hp, gameObject);
            _moveTransform = new MoveTransform(transform, _speed);
            _gun = new Gun(_barrel, _bullet, _force);
        }

        private void Update()
        {
            _moveTransform.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);
            
            if (Input.GetButtonDown("Fire1"))
            {
                _gun.Shoot();
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _healthManager.TakeDamage();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _healthManager.TakeDamage();
        }
    }
}