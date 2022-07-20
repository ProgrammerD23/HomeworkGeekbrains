using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly IMuffler _muffler;
        private readonly Vector3 _mufflerPosition;
        private GameObject muffler;

        public ModificationMuffler(IMuffler muffler, Vector3 mufflerPosition)
        {
            _muffler = muffler;
            _mufflerPosition = mufflerPosition;
        }

        protected override Weapon AddModification(Weapon weapon)
        {
            muffler = Object.Instantiate(_muffler.MufflerInstance, _mufflerPosition, Quaternion.identity);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }

        protected override Weapon RemoveModification(Weapon weapon)
        {
            Object.Destroy(muffler);
            return weapon;
        }
    }
}
