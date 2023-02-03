using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Algorithm
    {
        public void TextIndexRemover(string y)
        {
            int start = 1;
            int miktar = y.Length;
            while (start <= miktar)
            {
                int x = int.Parse(Console.ReadLine());
                y = y.Remove(x, 1);
                System.Console.WriteLine("Cevap: " + y);
                start++;
            }
        }
    }
}
