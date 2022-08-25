using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Observer
{
    public class ListenerHitShowDamage 
    {
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnOnHitChange;
        }
        public void Remove(IHit value)
        {
            value.OnHitChange -= ValueOnOnHitChange;
        }
        private void ValueOnOnHitChange(float damage)
        {
            Debug.Log(damage);
        }

    }
}
