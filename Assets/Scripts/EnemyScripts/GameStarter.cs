using System;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Prototype;
using Asteroids.Facade;

namespace Asteroids
{
    [Serializable]
    public sealed class GameStarter : MonoBehaviour
    {
        void Start()
        {
            //Enemy.CreateAsteroidEnemy(new EnemyHealth(100f, 100f));

            //factory.CreateAndMove(new EnemyHealth(100.0f, 100.0f));

            //EnemyShip enemyShipNew = enemyShip.DeepCopy();
            //enemyShipNew.CreateEnemyShip(-0.1f);

            var gameServies = new GameServies();
            gameServies.Start();
        }
    }
}
