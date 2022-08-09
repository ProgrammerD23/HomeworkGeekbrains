using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Chain_of_Responsibility
{
    internal sealed class AddAttackModifier : EnemyModifier
    {
        private readonly int _attack;
        public AddAttackModifier(Ship enemy, int attack)
        : base(enemy)
        {
            _attack = attack;
        }
        public override void Handle()
        {
            _enemy.Attack += _attack;
            base.Handle();
        }
    }
}
