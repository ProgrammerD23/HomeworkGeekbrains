using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.state
{
    public class StandingState : GroundedState
    {
        private bool jump;
        private bool crouch;

        public StandingState(Character character, StateMachine stateMachine) : base(character, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            speed = character.MovementSpeed;
            rotationSpeed = character.RotationSpeed;
            crouch = false;
            jump = false;
        }

        public override void HandleInput()
        {
            base.HandleInput();
            crouch = Input.GetButtonDown("Fire3");
            jump = Input.GetButtonDown("Jump");
        }

        
    }
}
