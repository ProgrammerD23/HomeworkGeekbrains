using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    public class PlayerHealth : MonoBehaviour, ITakeDamage
    {
        [SerializeField] private float _hp;

        public void Hit(float damage)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp -= damage;
            }
        }
    }
}
