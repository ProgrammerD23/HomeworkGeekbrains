using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Ship : IMove
    {
        private readonly IMove _moveImplementation;
        public float Force => _moveImplementation.Force;
        public int Attack;
        public Ship(IMove moveImplementation, int attack)
        {
            _moveImplementation = moveImplementation;
            Attack = attack;
        }
        public void Move(float deltaTime, Rigidbody rigidbody, float x, float y)
        {
            _moveImplementation.Move(deltaTime, rigidbody, x, y);
        }
        public void AddAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }
        public void RemoveAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }
    }
}

