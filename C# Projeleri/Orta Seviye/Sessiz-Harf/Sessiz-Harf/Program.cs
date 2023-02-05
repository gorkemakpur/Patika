namespace Sessiz_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n kelimeleri giriniz: ");
                string[] kelimeler = Console.ReadLine().Split();

                foreach (var item in kelimeler)
                {
                    bool def = false;

                    for (int i = 1; i < item.Length; i++)
                    {
                        if (sessizMi(item[i]) == sessizMi(item[i - 1]))
                            def = true;
                    }
                    Console.Write(def + " ");
                }

                bool sessizMi(char c)
                {
                    return !"aeıioöuü".ToCharArray().Contains(c);
                }
            }
        }
    }
}