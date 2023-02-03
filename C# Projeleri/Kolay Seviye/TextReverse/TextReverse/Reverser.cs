using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReverse
{
    public class Reverser
    {
        public void reverseText(string b)
        {
            string a = "";

            for (int i = b.Length - 1; i >= 0; i--)
            {
                a += b[i];
            }

            Console.WriteLine(a);
        }
    }
}
