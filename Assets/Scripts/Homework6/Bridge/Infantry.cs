using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Bridge
{
    public class Infantry : IMove
    {
        public void Move(Rigidbody rigidbody)
        {
            rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * 10f * Time.deltaTime);
        }
    }
}
