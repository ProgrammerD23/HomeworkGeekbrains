using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Decorator
{
    public class Aim : IAim
    {
        public Transform BarrelPositionAim { get; }
        public GameObject AimGameobject { get; }

        public Aim(Transform barrelPositionAim, GameObject aim)
        {
            BarrelPositionAim = barrelPositionAim;
            AimGameobject = aim;
        }
    }
}
