using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_hesapla
{
    public class Square
    {
        public void kareHesapla()
        {
            Console.WriteLine("Kenar giriniz  :");
            double kenar = Convert.ToInt32(Console.ReadLine());
            double alan =  kenar * kenar;
            Console.WriteLine("Karenin alanı:" + alan);
        }

    }
}
