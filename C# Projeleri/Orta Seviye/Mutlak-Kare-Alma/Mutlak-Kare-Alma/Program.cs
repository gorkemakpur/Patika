namespace Mutlak_Kare_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aralarında boşluk bırakarak sayı dizinizi giriniz (1 2 3 3 gibi):   ");
            string sayilar = Console.ReadLine();
            MutlakKareAlma(sayilar);
        }

        public static void MutlakKareAlma(string sayilar)
        {
            int toplamKucuk = 0;
            int toplamBuyuk = 0;
            int toplamBuyukKare = 0;
            int uzunluk = 0;

            string[] dizi = sayilar.Split(' ');

            uzunluk = Convert.ToInt32(dizi.Length);


            for (int i = 0; i < uzunluk; i++)
            {
                if (Convert.ToInt32(dizi[i]) < 67)
                {
                    toplamKucuk += 67 - Convert.ToInt32(dizi[i]);


                }
                else
                {
                    toplamBuyuk = (Convert.ToInt32(dizi[i]) - 67);
                    toplamBuyukKare += toplamBuyuk * toplamBuyuk;

                }
            }

            Console.Write(toplamKucuk + " ");
            Console.Write(toplamBuyukKare + " ");
        }

    }
}