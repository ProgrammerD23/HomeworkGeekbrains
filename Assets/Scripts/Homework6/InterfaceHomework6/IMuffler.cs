using UnityEngine;

namespace Asteroids.Decorator
{
    internal interface IMuffler
    {
        Transform BarrelPositionMuffler { get; }
        GameObject MufflerInstance { get; }
    }
}
