using System;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Prototype;

namespace Asteroids
{
    [Serializable]
    public sealed class GameStarter : MonoBehaviour
    {
        void Start()
        {
            //Enemy.CreateAsteroidEnemy(new EnemyHealth(100f, 100f));

            IEnemyFactory factory = new AsteroidFactory();
            //factory.CreateAndMove(new EnemyHealth(100.0f, 100.0f));
            Enemy.Factory = factory;
            Enemy.Factory.CreateAndMove(new EnemyHealth(100.0f, 100.0f));
            EnemyShip enemyShip = gameObject.AddComponent<EnemyShip>();
            enemyShip.CreateEnemyShip(-1f);
            //EnemyShip enemyShipNew = enemyShip.DeepCopy();
            //enemyShipNew.CreateEnemyShip(-0.1f);
        }
    }
}
