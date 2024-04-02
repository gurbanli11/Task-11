using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask.Models
{
    internal class Weapon
    {
        public int BulletCapacity;
        public int BulletNum;
        public int FinishSecond;
        public bool SingleShootingMode;
        public bool AutomaticShootingMode;


        public Weapon(int bulletCapacity, int bulletNum, int finishSecond, bool singleShootingMode, bool automaticShootingMode)
        {
            BulletCapacity = bulletCapacity;
            BulletNum = bulletNum;
            FinishSecond = finishSecond;
            SingleShootingMode = singleShootingMode;
            AutomaticShootingMode = automaticShootingMode;
        }
    
        public void Shoot()
        {
            if (SingleShootingMode)
            {
                if (BulletNum==0)
                {
                    Console.WriteLine("Daraqda gulle yoxdur");
                }
                BulletNum--;
                Console.WriteLine("1 gulle atildi");
            }
        }
        public void Fire()
        {
            while (BulletNum>0)
            {
                BulletNum--;
            }
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine(BulletCapacity-BulletNum);
        }
        public void Reload()
        {
            while (BulletNum==BulletCapacity)
            {
                BulletNum++;
            }
        }
        public void ChangeFireMode()
        {

        }
    }
}
