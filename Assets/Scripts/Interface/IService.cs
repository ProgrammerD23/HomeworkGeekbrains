namespace Asteroids.ServiceLocator
{
    public interface IService
    {
        public BulletScript GetEnemy(string type);
    }
}
