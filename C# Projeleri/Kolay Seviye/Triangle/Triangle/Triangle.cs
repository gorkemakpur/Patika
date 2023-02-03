using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public void triangle(int c)
        {
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j < i)
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
