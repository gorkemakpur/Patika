namespace Karakter_Degistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aralarında boşluk bırakarak metin (Merhaba Dunya Nasılsın , gibi):   ");
            string text = Console.ReadLine();
            textIlkSonHarfDegistir(text);
        }


        public static void textIlkSonHarfDegistir(string text)
        {

            int uzunluk = 0;
            string[] dizi = text.Split(" ");
            char temp;
            uzunluk = Convert.ToInt32(dizi.Length);
            string[] yeniDizi=new string[uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                char[] kelimeHarfleri = dizi[i].ToCharArray();
                temp = kelimeHarfleri[0];


                kelimeHarfleri[0] = kelimeHarfleri[dizi[i].Length - 1];
                kelimeHarfleri[dizi[i].Length - 1] = temp;
                string yeniKelime = string.Concat(kelimeHarfleri);
                yeniDizi[i] = yeniKelime;
            }

            foreach (var item in yeniDizi)
            {
                Console.Write(item+" ");

            }
        }
    }
}