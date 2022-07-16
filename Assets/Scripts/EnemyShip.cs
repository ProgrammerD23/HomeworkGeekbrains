using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids
{
    [Serializable]
    public class EnemyShip : Enemy
    {
        public void CreateEnemyShip(float move)
        {
            var enemy = Object.Instantiate(Resources.Load<EnemyShip>("Prefabs/EnemyShip"));
            enemy.Move(move);
        }
    }
}
