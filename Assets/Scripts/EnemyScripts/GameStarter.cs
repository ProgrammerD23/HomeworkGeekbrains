using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class GameStarter : MonoBehaviour
    {
        void Start()
        {
            //Enemy.CreateAsteroidEnemy(new EnemyHealth(100f, 100f));

            IEnemyFactory factory = new AsteroidFactory();
            //factory.CreateAndMove(new EnemyHealth(100.0f, 100.0f));
            Enemy.Factory = factory;
            Enemy.Factory.CreateAndMove(new EnemyHealth(100.0f, 100.0f));
            EnemyShip.CreateEnemyShip();
        }
    }
}
