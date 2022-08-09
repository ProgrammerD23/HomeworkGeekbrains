using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Asteroids.Command
{
    internal sealed class Slot : BaseUI
    {
        [SerializeField] private GameObject slot;

        public override void Execute()
        {
            slot.SetActive(true);
        }

        public override void Cancel()
        {
            slot.SetActive(false);
        }
    }
}
