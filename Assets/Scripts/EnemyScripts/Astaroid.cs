using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class Astaroid : Enemy
    {
        [SerializeField] private float damage = 10;
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.TryGetComponent(out ITakeDamage takeDamage))
            {
                takeDamage.Hit(damage);
            }
        }
    }
}
