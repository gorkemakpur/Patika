using TelefonRehberiUygulamasi.Actions;

namespace TelefonRehberiUygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program:
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("  *******************************************");
            Console.WriteLine("  (1) Yeni Numara Kaydetmek");
            Console.WriteLine("  (2) Varolan Numarayı Silmek");
            Console.WriteLine("  (3) Varolan Numarayı Güncelleme");
            Console.WriteLine("  (4) Rehberi Listelemek");
            Console.WriteLine("  (5) Rehberde Arama Yapmak﻿");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Add add = new Add();
                    add.AddNumber();
                    break;
                case "2":
                    Delete delete = new Delete();
                    delete.DeleteNumber();
                    break;
                case "3":
                    Update update = new Update();
                    update.UpdateNumber();
                    break;
                case "4":
                    List list = new List();
                    list.ListPhoneBook();
                    break;
                    
                case "5":
                    Search search = new Search();
                    search.SearchNumber();
                    break;



            }



        }
    }
}