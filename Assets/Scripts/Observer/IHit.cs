using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Observer
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);

    }
}
