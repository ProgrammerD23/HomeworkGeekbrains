using UnityEngine;
namespace Asteroids.Bridge
{

    public interface IAttack
    {
        void Attack(Transform bulPosition, Rigidbody bulRigidbody);
    }
}
