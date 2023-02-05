using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_hesapla
{
    public class Circle
    {
        public void cemberAlanHesapla()
        {
            Console.WriteLine("Yarıçap giriniz  :");
            double yaricap = Convert.ToInt32(Console.ReadLine());
            double CircleArea = Math.PI * yaricap * yaricap;
            Console.WriteLine("Çemberin Alanı  :  " + CircleArea);
        }

        public void cemberCevreHesapla()
        {
            Console.WriteLine("Yarıçap giriniz  :");
            double yaricap = Convert.ToInt32(Console.ReadLine());
            double CircleArea =2 * Math.PI * yaricap;
            Console.WriteLine("Çemberin çevresi  :  " + CircleArea);
        }
    }
}
