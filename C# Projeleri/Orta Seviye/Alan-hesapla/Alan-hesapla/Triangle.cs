using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_hesapla
{
    public class Triangle
    {
        public void ucgenAlanHesapla()
        {
            Console.WriteLine("Yükseklik giriniz  :");
            double yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Taban uzunluğu giriniz  :");
            double taban = Convert.ToInt32(Console.ReadLine());

            double ucgenAlan = (yukseklik*taban)/2;
            Console.WriteLine("Square Area:" + ucgenAlan);
        }
    }
}
