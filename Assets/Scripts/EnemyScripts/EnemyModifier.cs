using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids;

namespace Asteroids.Chain_of_Responsibility 
{
    internal class EnemyModifier
    {
        protected Ship _enemy;
        protected EnemyModifier Next;
        public EnemyModifier(Ship enemy)
        {
            _enemy = enemy;
        }
        public void Add(EnemyModifier cm)
        {
            if (Next != null)
            {
                Next.Add(cm);
            }
            else
            {
                Next = cm;
            }
        }
        public virtual void Handle() => Next?.Handle();
    }
}
