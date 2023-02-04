using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_hesapla
{
    public class Circle
    {
        public void circleCalculate()
        {
            Console.WriteLine("Yarıçap giriniz  :");
            double yaricap = Convert.ToInt32(Console.ReadLine());
            double CircleArea = Math.PI * yaricap * yaricap;
            Console.WriteLine("Çemberin Alanı  :  " + CircleArea);
        }
    }
}
