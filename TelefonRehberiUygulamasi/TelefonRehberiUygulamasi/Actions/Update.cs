using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiUygulamasi.Data;

namespace TelefonRehberiUygulamasi.Actions
{
    public class Update
    {

        public void UpdateNumber()
        {
            Person person = new Person();
            List listedPersons = new List();

        update:
            while (true)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string nameSurname = Console.ReadLine();

                if (PhoneBookData.PhoneList.Any(x => x.FirstName == nameSurname || x.LastName == nameSurname))
                {
                    person = PhoneBookData.PhoneList.Find(x => x.FirstName == nameSurname || x.LastName == nameSurname);

                    Console.WriteLine("Yeni numarayı giriniz: ");

                    person.PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Güncelleme başarılı.");

                    listedPersons.ListPhoneBook();
                    break;
                }

                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. " +
                        "\n* Güncellemeyi sonlandırmak için : (1) " +
                        "\n* Yeniden denemek için :      (2)");


                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        break;
                    }
                    else if (choice == 2)
                    {
                        goto update;
                    }

                }
            }
        }
    }

}
