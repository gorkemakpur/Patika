namespace Fibo_Ortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Derinlik girin: ");
            int derinlik =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(derinlik);

            int x = 1;
            int y = 1;
            int z = 0;
            int sayac = 0;
            for (int i = 0; i < derinlik; i++)
            {
                z = x + y;
                x = y;
                y = z;
                sayac = sayac + 1;
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Ortalama:   "+Convert.ToDouble(z)/sayac);
        }
    }
}