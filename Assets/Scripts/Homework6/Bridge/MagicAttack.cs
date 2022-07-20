using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Bridge
{
    internal sealed class MagicAttack : IAttack
    {
        public void Attack(Transform bulPosition, Rigidbody bulRigidbody)
        {
            var bulle = Object.Instantiate(bulRigidbody, bulPosition.position, Quaternion.identity);
            bulle.AddForce(bulPosition.forward * 200f);
            Object.Destroy(bulle, 4f);
        }
    }
}
