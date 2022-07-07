using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class EnemyShip : Enemy
    {
        public static void CreateEnemyShip()
        {
            var enemy = Object.Instantiate(Resources.Load<EnemyShip>("Prefabs/EnemyShip"));
            enemy.Move(-1f);
        }
    }
}
