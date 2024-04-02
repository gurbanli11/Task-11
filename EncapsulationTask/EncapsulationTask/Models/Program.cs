namespace EncapsulationTask.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            Console.WriteLine(weapon.BulletCapacity);
            weapon.Fire();
            weapon.Shoot();
            int num;
            do
            {
                Console.WriteLine(@"0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - Fire metodu üçün
3 -  GetRemainBulletCount metodu üçün
4 - Reload metodu üçün
5 - ChangeFireMode metodu üçün
6 - Proqramdan dayandırmaq üçün
qısayoldur.
7 - Redaktə et :
T - Tutumu dəyişsin
S - Güllə sayı
D - Sıfırlama saniyəsi");
                if (int.TryParse(Console.ReadLine() ,out num)
                {
                    switch (num)
                    {
                        case 0:
                            weapon.GetInfo();
                            break;
                        case 1:
                            weapon.Shoot();
                            break;
                        case 2:
                            weapon.Fire();
                            break;
                        case 3:
                            weapon.GetRemainBulletCount();
                            break;
                        case 5:
                            weapon.ChangeFireMode();
                            break;
                        default:
                            Console.WriteLine()

                    }
                }

            } while ();
        }
    }
}