namespace integer_ikililerin_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aralarında boşluk bırakarak sayı dizinizi giriniz (1 2 3 3 gibi):   ");
            string sayilar = Console.ReadLine();
            IntegerIkililerinToplami(sayilar);
        }

        public static void IntegerIkililerinToplami(string sayilar)
        {
            int toplam = 0;
            int uzunluk = 0;

            string[] dizi = sayilar.Split(' ');

            uzunluk = Convert.ToInt32(dizi.Length);

            if(uzunluk % 2 == 0) { 

            for (int i = 0; i < uzunluk; i += 2)
            {
                if (dizi[i] == dizi[i + 1])
                {
                    toplam = Convert.ToInt32(dizi[i]) + int.Parse(dizi[i + 1]);
                    Console.Write(toplam * toplam);
                }
                else
                {
                    toplam = Convert.ToInt32(dizi[i]) + Convert.ToInt32(dizi[i + 1]);
                    Console.Write(toplam);
                }
            }
            }

            else
            {
                Console.WriteLine("tek sayı girmeyiniz");
            }
        }

    }
}

