using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Observer
{
    public class EnemyTest : MonoBehaviour, IHit
    {
        public event Action<float> OnHitChange = delegate (float f) { };
        public void Hit(float damage)
        {
            OnHitChange.Invoke(damage);
        }
    }
}
