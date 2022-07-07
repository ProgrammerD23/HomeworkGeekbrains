using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidFactory : IEnemyFactory
    {
        public Enemy CreateAndMove(EnemyHealth hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Astaroid>("Enemy/Astaroid"));
            enemy.DependencyInjectHealth(hp);
            enemy.Move(-25f);
            return enemy;
        }
    }
}
