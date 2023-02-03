namespace TextReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("metninizi giriniz :        ");
            string y = Console.ReadLine();
            Reverser reverser = new Reverser();

            reverser.reverseText(y);
           
        }
    }
}