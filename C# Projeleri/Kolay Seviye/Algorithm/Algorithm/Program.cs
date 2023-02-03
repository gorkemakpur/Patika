namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

                System.Console.WriteLine("metninizi giriniz :        ");
                string y = Console.ReadLine();
                System.Console.WriteLine("silmek istediğiniz indexi giriniz");
                Algorithm algorithm = new Algorithm();

                algorithm.TextIndexRemover(y);
            
                

            
        }
    }
}
      