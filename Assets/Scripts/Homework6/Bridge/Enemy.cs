using UnityEngine;
namespace Asteroids.Bridge
{
    internal sealed class Enemy 
    {
        private readonly IAttack _attack;
        private readonly IMove _move;
        public Enemy(IAttack attack, IMove move)
        {
            _attack = attack;
            _move = move;
        }
        public void Attack(Transform bulPosition, Rigidbody bulRigidbody)
        {
            _attack.Attack(bulPosition, bulRigidbody);
        }
        public void Move(Rigidbody rigidbody)
        {
            _move.Move(rigidbody);
        }
    }
}
