using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Chain_of_Responsibility;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        private Camera _camera;
        private Ship _ship;
        private Rigidbody rigidbodyPlayer;
        private void Start()
        {
            _camera = Camera.main;
            rigidbodyPlayer = GetComponent<Rigidbody>();
            var moveTransform = new AccelerationMove(transform, _speed,_acceleration);
            _ship = new Ship(moveTransform, 1);
            var root = new EnemyModifier(_ship);
            root.Add(new AddAttackModifier(_ship, 10));
        }
        private void Update()
        {
            /*_ship.Move(Time.deltaTime, rigidbodyPlayer, Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }*/
            
        }
    }
}
