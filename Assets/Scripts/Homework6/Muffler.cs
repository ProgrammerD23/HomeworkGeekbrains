using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class Muffler : IMuffler
    {
        public Transform BarrelPositionMuffler { get; }
        public GameObject MufflerInstance { get; }

        public Muffler(Transform barrelPositionMuffler, GameObject mufflerInstance)
        {
            BarrelPositionMuffler = barrelPositionMuffler;
            MufflerInstance = mufflerInstance;
        }
    }
}
