using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;
using Asteroids.Iterator;
using Asteroids.Observer;

namespace Asteroids
{
    [Serializable]
    public sealed class EnemyShip : Enemy
    {
        public void CreateEnemyShip(float move)
        {
            var enemy = Object.Instantiate(Resources.Load<EnemyShip>("Prefabs/EnemyShip"));
            enemy.Move(move);
        }
    }
}
