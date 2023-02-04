namespace Alan_hesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplamak istediğiniz şekli seçiniz");
            Console.WriteLine("**************************************************");
            Console.WriteLine("çember                  (1)");
            Console.WriteLine("Üçgen                   (2)");
            Console.WriteLine("Kare                    (3)");
            Console.WriteLine("Dikdörtgen              (4)");

            int choice = int.Parse(Console.ReadLine());

            
            switch(choice)
            {
                case 1:
                    Circle circle = new Circle();
                    circle.circleCalculate();
                    break;

                case 2:
                    Triangle triangle = new Triangle();
                    triangle.ucgenAlanHesapla();
                    break;

                case 3:
                    Square square = new Square();
                    square.kareHesapla();
                    break;
                case 4:
                    Rectangle rectangle = new Rectangle();
                    rectangle.dikdortgenAlanHesapla();
                    break;


            }

        }
    }
}