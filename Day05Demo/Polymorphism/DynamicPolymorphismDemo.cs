using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05Demo.Polymorphism
{
    internal class DynamicPolymorphismDemo
    {
        private static IShootingWeapon _primary, _secondary;
              
        public static void Test()
        {
            _primary = new Pistol();
            _secondary = null;

            _primary = new ShotGun();
            _primary.Show();        // ShootingWeapon Show // Showing Dancing Show
            _primary.Fire();        // ShotGun Firing
            _primary.Reload();      // ShotGun Reload
            _primary.Hide();        // ShootingWeapon Hide

            _secondary = new Ak47();
            _secondary.Show();      // ShootingWeapon Show 
            _secondary.Fire();      // Ak47 Fire
            _secondary.Reload();    // Ak47 Reload
            _secondary.Hide();      // ShootingWeapon Hide

            _primary = new Pistol();
            _primary.Show();        // ShootingWeapon Show
            _primary.Fire();        // Pistol Fire
            _primary.Reload();      // Pistol Reload
            _primary.Hide();        // ShootingWeapon Hide
        }
    }

    // Full Team including Team Leader
    interface IShootingWeapon
    {
        public void Show();
        public void Reload();
        public void Fire();
        public void Hide();
    }

    // Salim, Pooja, Tejas
    abstract class ShootingWeapon : IShootingWeapon
    {
        protected int _magazineCapacity, _range, _damageFactor;
        public abstract void Fire();

        public virtual void Hide()
        {
            Console.WriteLine("Hiding ShootingWeapon");
        }

        public abstract void Reload();

        public virtual void Show()
        {
            Console.WriteLine("Showing ShootingWeapon");
        }
    }

    // Salim - Pistol
    class Pistol : ShootingWeapon
    {
        public Pistol()
        {
            _magazineCapacity = 6;
            _range = 50;
            _damageFactor = 3;
        }

        public override void Fire()
        {
            Console.WriteLine("Pistol is firing");
        }

        public override void Reload()
        {
            Console.WriteLine("Pistol is reloading");
        }
    }

    // Pooja - Ak47
    class Ak47 : ShootingWeapon
    {
        public Ak47()
        {
            _magazineCapacity = 40;
            _range = 150;
            _damageFactor = 7;
        }

        public override void Fire()
        {
            Console.WriteLine("Ak47 is firing");
        }

        public override void Reload()
        {
            Console.WriteLine("Ak47 is reloading");
        }
    }

    // Tejas - Shotgun
    class ShotGun : ShootingWeapon
    {
        public ShotGun()
        {
            _magazineCapacity = 2;
            _range = 10;
            _damageFactor = 10;
        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("Showing Dancing Show!!");
        }

        public override void Fire()
        {
            Console.WriteLine("ShotGun is firing");
        }

        public override void Reload()
        {
            Console.WriteLine("ShotGun is reloading");
        }
    }    
}
