using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class Weapon : IFire
    {
        private Transform _barrelPosition;
        private IAmmunition _bullet;
        private float _force;

        public Weapon(Transform barrelPosition, IAmmunition bullet, float force)
        {
            _barrelPosition = barrelPosition;
            _bullet = bullet;
            _force = force;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
        }
    }
}
