using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bullet.Object_Pool;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private Transform _barrel;
    [SerializeField] private float _force;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            BulletPool enemyPool = new BulletPool(1);
            var enemy = enemyPool.GetEnemy("Bullet");
            enemy.transform.position = _barrel.position;
            enemy.gameObject.SetActive(true);
            var rigidbody = enemy.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(_barrel.up * _force);
        }
    }
}
