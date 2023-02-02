using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiUygulamasi.Data;

namespace TelefonRehberiUygulamasi.Actions
{
    public class Search
    {
        public void SearchNumber()
        {
            while (true)
            {
                Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz." 
                    +" \n  ********************************************** \n  " 
                    +" \n  İsim veya soyisime göre arama yapmak için: (1)"
                    +" \n  Telefon numarasına göre arama yapmak için: (2) ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Lütfen aramak istediğiniz isim veya soyismi giriniz: ");
                    string nameSurname = Console.ReadLine();

                    foreach (var item in PhoneBookData.PhoneList)
                    {
                        if (item.FirstName == nameSurname || item.LastName == nameSurname)
                        {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon numarası : {item.PhoneNumber}");
                            Console.WriteLine("-");
                        }
                        else
                        {
                            Console.WriteLine("Veri Bulunamadı");
                            break;
                        }
                    }                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz: ");
                    string number = Console.ReadLine(); 

                    foreach (var item in PhoneBookData.PhoneList)
                    {
                        if (item.PhoneNumber == number)
                        {
                            Console.WriteLine($"İsim : {item.FirstName}");
                            Console.WriteLine($"Soyisim : {item.LastName}");
                            Console.WriteLine($"Telefon numarası : {item.PhoneNumber}");
                            Console.WriteLine("-"); 
                        }
                        else
                        {
                            Console.WriteLine("Veri Bulunamadı");
                            break;
                        }
                    }
                     
                }
                break;
            }
        }
    }
}
