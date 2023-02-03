namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yarıçap      :");
            int r = int.Parse(Console.ReadLine());

            Circle circle = new Circle();
            circle.DrawCircle(r);


            
        }
    }
}