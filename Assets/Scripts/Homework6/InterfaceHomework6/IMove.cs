using UnityEngine;
namespace Asteroids.Bridge
{

    public interface IMove 
    {
        void Move(Rigidbody rigidbody);
    }
}
