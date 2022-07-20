using Asteroids;
using UnityEngine;
namespace Asteroids.Facade
{
    public class GameServies : MonoBehaviour
    {
        public void Start()
        {
            IEnemyFactory factory = new AsteroidFactory();
            Enemy.Factory = factory;
            Enemy.Factory.CreateAndMove(new EnemyHealth(100.0f, 100.0f));
            EnemyShip enemyShip = new EnemyShip();
            enemyShip.CreateEnemyShip(-1f);
        }
    }
}
