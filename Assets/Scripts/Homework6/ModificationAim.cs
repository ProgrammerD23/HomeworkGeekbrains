using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ModificationAim : ModificationWeapon
    {
        private readonly IAim _aim;
        private readonly Vector3 _aimPOsition;
        private GameObject aim;

        public ModificationAim(IAim aim, Vector3 aimPosition)
        {
            _aim = aim;
            _aimPOsition = aimPosition;
        }

        protected override Weapon AddModification(Weapon weapon)
        {
            aim = Object.Instantiate(_aim.AimGameobject, _aimPOsition, Quaternion.identity);
            return weapon;
        }

        protected override Weapon RemoveModification(Weapon weapon)
        {
            Object.Destroy(aim);
            return weapon;
        }
    }
}
