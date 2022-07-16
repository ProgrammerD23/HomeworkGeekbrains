using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    [System.Serializable]
    public abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public EnemyHealth EnemyHealth { get; private set; }

        public static Astaroid CreateAsteroidEnemy(EnemyHealth hp)
        {
            var enemy = Instantiate(Resources.Load<Astaroid>("Enemy/Astaroid"));

            enemy.EnemyHealth = hp;

            return enemy;
        }

        public void DependencyInjectHealth(EnemyHealth hp)
        {
            EnemyHealth = hp;
        }

        public void Move(float force)
        {
            var enemyRigidbody = GetComponent<Rigidbody>();
            Transform vector = GetComponent<Transform>();

            enemyRigidbody.AddForce(vector.up * force);
        }
    }
}
