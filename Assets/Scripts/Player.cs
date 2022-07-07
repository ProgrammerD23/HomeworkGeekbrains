using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            _ship = new Ship(moveTransform);
        }
        private void Update()
        {
            _ship.Move(Time.deltaTime, rigidbodyPlayer, Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }
            
        }
    }
}
