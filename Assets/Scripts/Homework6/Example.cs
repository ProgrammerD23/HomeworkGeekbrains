using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class Example : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;

        [Header("Muffler Gun")]
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;
        [SerializeField] private Transform _barrelPositionAim;
        [SerializeField] private GameObject _aim;
        private ModificationWeapon modificationWeapon;
        private ModificationAim modificationAim;
        Weapon weapon;

        void Start()
        {
            IAmmunition ammunition = new BulletHomework6(_bullet, 3.0f);
            weapon = new Weapon(_barrelPosition, ammunition, 999.0f);

            var muffler = new Muffler(_barrelPositionMuffler, _muffler);
            var aim = new Aim(_barrelPositionAim, _aim);
            modificationWeapon = new ModificationMuffler(muffler, _barrelPositionMuffler.position);
            modificationWeapon.ApplyModification(weapon);
            _fire = modificationWeapon;
            modificationAim = new ModificationAim(aim, _barrelPositionAim.position);
            modificationAim.ApplyModification(weapon);
            
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                modificationWeapon.DestroyModification(weapon);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                modificationAim.DestroyModification(weapon);
            }
        }
    }
}
