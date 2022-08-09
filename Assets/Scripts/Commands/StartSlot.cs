using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Command
{
    public class StartSlot : MonoBehaviour
    {
        [SerializeField] private Slot slot;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                slot.Execute();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                slot.Cancel();
            }
        }
    }
}
