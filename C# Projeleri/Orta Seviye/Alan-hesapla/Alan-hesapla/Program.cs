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

            
            switch (choice)
            {
                #region çember
                case 1:
                    Circle circle = new Circle();
                    Console.WriteLine("neyi hesaplamak istiyorsunuz?");
                    Console.WriteLine("alan                  (1)");
                    Console.WriteLine("çevre                 (2)");
                    int secim1 = int.Parse(Console.ReadLine());
                    switch (secim1)
                    {
                        case 1:
                            circle.cemberAlanHesapla();
                            break;
                        case 2:
                            circle.cemberCevreHesapla();
                            break;

                    }
                    break;
                #endregion

                #region ucgen
                case 2:
                    Triangle triangle = new Triangle();

                    Console.WriteLine("neyi hesaplamak istiyorsunuz?");
                    Console.WriteLine("alan                  (1)");
                    Console.WriteLine("çevre                 (2)");
                    int secim2 = int.Parse(Console.ReadLine());
                    switch (secim2)
                    {
                        case 1:
                            triangle.ucgenAlanHesapla();
                            break;
                        case 2:
                            triangle.ucgenCevreHesapla();
                            break;

                    }
                    break;

                #endregion

                #region kare
                case 3:
                    Square square = new Square();
                    Console.WriteLine("neyi hesaplamak istiyorsunuz?");
                    Console.WriteLine("alan                  (1)");
                    Console.WriteLine("çevre                 (2)");
                    int secim3 = int.Parse(Console.ReadLine());
                    switch (secim3)
                    {
                        case 1:
                            square.kareAlanHesapla();
                            break;
                        case 2:
                            square.kareCevreHesapla();
                            break;

                    }
                    break;

                #endregion

                #region dikdörtgen
                case 4:
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("neyi hesaplamak istiyorsunuz?");
                    Console.WriteLine("alan                  (1)");
                    Console.WriteLine("çevre                 (2)");
                    int secim4 = int.Parse(Console.ReadLine());
                    switch (secim4)
                    {
                        case 1:
                            rectangle.dikdortgenAlanHesapla();
                            break;
                        case 2:
                            rectangle.dikdortgenCevreHesapla();
                            break;

                    }
                    break;
                    #endregion
            }

        }
    }
}