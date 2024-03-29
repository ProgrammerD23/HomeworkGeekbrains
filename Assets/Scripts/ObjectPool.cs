using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;
using Asteroids;
using Asteroids.ServiceLocator;

namespace Bullet.Object_Pool
{
    internal sealed class BulletPool : IService
    {
        private readonly Dictionary<string, HashSet<BulletScript>> _enemyPool;
        private readonly int _capacityPool;
        private Transform _rootPool;
        public BulletPool(int capacityPool)
        {
            _enemyPool = new Dictionary<string, HashSet<BulletScript>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                _rootPool = new
                GameObject(NameManager.POOL_AMMUNITION).transform;
            }
        }
        public BulletScript GetEnemy(string type)
        {
            BulletScript result;
            switch (type)
            {
                case "Bullet":
                    result = GetAsteroid(GetListEnemies(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type,
                    "�� ������������ � ���������");
            }
            return result;
        }
        private HashSet<BulletScript> GetListEnemies(string type)
        {
            return _enemyPool.ContainsKey(type) ? _enemyPool[type] :
            _enemyPool[type] = new HashSet<BulletScript>();
        }
        private BulletScript GetAsteroid(HashSet<BulletScript> enemies)
        {
            var enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (enemy == null)
            {
                var laser = Resources.Load<BulletScript>("Prefabs/Bullet");
                for (var i = 0; i < _capacityPool; i++)
                {
                    var instantiate = Object.Instantiate(laser);
                    ReturnToPool(instantiate.transform);
                    enemies.Add(instantiate);
                }

                GetAsteroid(enemies);
            }
            enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            return enemy;
        }
        private void ReturnToPool(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.gameObject.SetActive(false);
            transform.SetParent(_rootPool);
        }
        public void RemovePool()
        {
            Object.Destroy(_rootPool.gameObject);
        }
    }
}

