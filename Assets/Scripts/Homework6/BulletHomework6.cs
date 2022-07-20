using UnityEngine;

namespace Asteroids.Decorator {
    public class BulletHomework6 : IAmmunition
    {
        public Rigidbody BulletInstance { get; }
        public float TimeToDestroy { get; }

        public BulletHomework6(Rigidbody bulletInstance, float timeToDestroy)
        {
            BulletInstance = bulletInstance;
            TimeToDestroy = timeToDestroy;
        }
    }
}
