using UnityEngine;

namespace Rocket
{
    internal sealed class GameObjectPhysicsBuilder : GameObjectBuilder
    {
        public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject) { }
        
        public GameObjectPhysicsBuilder RigidBody2D(float mass, Vector2 addForce)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            component.AddForce(addForce);
            return this;
        }
        public GameObjectPhysicsBuilder RigidBody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return this;
        }

        public GameObjectPhysicsBuilder BoxCollider2D()
        {
            GetOrAddComponent<BoxCollider2D>();
            return this;
        }

        private T GetOrAddComponent<T>() where T : Component 
        {
            var result = _gameObject.GetComponent<T>();
            if(!result)
                result = _gameObject.AddComponent<T>();
            return result;
        }
    }
}
