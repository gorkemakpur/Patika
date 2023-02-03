namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Boyut Giriniz     : ");
            int c = Convert.ToInt32(Console.ReadLine());

            Triangle triangle = new Triangle();
            triangle.triangle(c);
            
        }
    }
}