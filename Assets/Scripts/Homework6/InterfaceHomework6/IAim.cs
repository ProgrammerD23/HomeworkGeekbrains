using UnityEngine;

namespace Asteroids.Decorator
{
    public interface IAim
    {
        public Transform BarrelPositionAim { get; }
        public GameObject AimGameobject { get; }
    }
}
