using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_hesapla
{
    public class Rectangle
    {
 
        public void dikdortgenAlanHesapla()
        {
            Console.WriteLine("Kısa kenarı giriniz : ");
            double kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz : ");
            double uzunKenar = Convert.ToInt32(Console.ReadLine());


            double dikdortgenAlan = uzunKenar * kisaKenar;
            Console.WriteLine("Square Area:" + dikdortgenAlan);
        }

        public void dikdortgenCevreHesapla()
        {
            Console.WriteLine("Kısa kenarı giriniz : ");
            double kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz : ");
            double uzunKenar = Convert.ToInt32(Console.ReadLine());

            double dikdortgenCevre = uzunKenar * 2 + kisaKenar * 2;
            Console.WriteLine("Square Area:" + dikdortgenCevre);
        }
    }
}
