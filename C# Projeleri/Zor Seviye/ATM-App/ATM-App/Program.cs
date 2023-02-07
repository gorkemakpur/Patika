namespace ATM_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController();
            InMemory inMemory = new InMemory();

            //dosya işlemleri
            string path = @"C:\ATM_logs\";
            string fileName = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt"; 
            string fullPath = Path.Combine(path, fileName); 

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

          
            //giriş kısmı
            Console.Write("Kart Numarası : ");
            string cardNumber = Console.ReadLine();

            Console.Write("Şifre :  ");
            string password = Console.ReadLine();
            //kontrol
            string login = userController.Controller(cardNumber, password);

            if (login == "success")
            {
                while (true)
                {
                    Console.WriteLine(" \n Hoşgeldiniz, \n 1. Bakiyeyi göster \n 2. Para yatır \n 3. Para Çek");
                    int selection = int.Parse(Console.ReadLine());
                    //bakiye gösterme
                    if (selection == 1)
                    {
                        User user = inMemory.GetByUser(cardNumber);
                        Console.WriteLine("Güncel Bakiyeniz : " + user.Balance);
                    }
                    //para yatırma
                    if (selection == 2)
                    {
                        User user = inMemory.GetByUser(cardNumber);

                        Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
                        int tutar = Convert.ToInt32(Console.ReadLine());

                        int total = user.Balance + tutar;
                        Console.WriteLine("İşlem başarılı güncel bakiyeniz = " + total);

                        inMemory.BalanceUpdate(cardNumber, total);

                        //loglama
                        using (StreamWriter sw = new StreamWriter(fullPath))
                        {
                            sw.WriteLine("Gün Sonu Logları");
                            sw.WriteLine("----------------");
                            sw.WriteLine("\n #Kart Numarası :  " + cardNumber +
                                "\n - Yatırılan Para : " + tutar +
                                "\n - Toplam Tutar : " + total);
                        }


                    }
                    //para çekme
                    if (selection == 3)
                    {
                        Console.Write("Çekmek istediğiniz tutarı giriniz : ");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        int total = 0;
                        User user = inMemory.GetByUser(cardNumber);
                        if (tutar < user.Balance)
                        {
                            total = user.Balance - tutar;
                            Console.WriteLine(" \n İşlem başarılı güncel bakiye : " + total);
                            inMemory.BalanceUpdate(cardNumber, total);
                        }
                        if (tutar > user.Balance)
                        {
                            Console.WriteLine("Bakiyeniz yetersiz ! ");
                        }
                        //loglama
                        using (StreamWriter sw = new StreamWriter(fullPath))
                        {
                            sw.WriteLine("Gün Sonu Logları");
                            sw.WriteLine("----------------");
                            sw.WriteLine("\n #Kart Numarası :  " + cardNumber +
                                "\n - Çekilen Para : " + tutar +
                                "\n - Toplam Tutar : " + total);
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Şifre veya kart numarası ! ");
            }
        }
    }
}