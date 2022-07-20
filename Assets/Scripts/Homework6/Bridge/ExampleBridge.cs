using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Bridge
{
    public class ExampleBridge : MonoBehaviour
    {
        [SerializeField] private GameObject bul;
        [SerializeField] private Transform bulPosition;
        [SerializeField] private Rigidbody bulRigidbody;
        [SerializeField] private Rigidbody enemyRigidbody;
        private Enemy enemy;

        void Start()
        {
            enemy = new Enemy(new MagicAttack(), new Infantry());
            //enemy.Attack(bul, bulPosition, bulRigidbody);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                enemy.Attack(bulPosition, bulRigidbody);
            }
            enemy.Move(enemyRigidbody);
        }
    }
}
