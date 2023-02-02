using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiUygulamasi.Data;

namespace TelefonRehberiUygulamasi.Actions
{
    public class Delete
    {
        public void DeleteNumber()
        {
            deletenumber:

            while (true)
            {
                Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                var nameSurname = Console.ReadLine();
                if(PhoneBookData.PhoneList.Any(x=>x.FirstName == nameSurname || x.LastName == nameSurname))
                {
                    Console.WriteLine("  {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", nameSurname);
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "y")
                    {
                        PhoneBookData.PhoneList.RemoveAt(PhoneBookData.PhoneList.FindIndex(x => x.FirstName == nameSurname || x.LastName == nameSurname));
                        List listPhoneBook = new List();
                        listPhoneBook.ListPhoneBook();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n   * Silmeyi sonlandırmak için : (1) \n   * Yeniden denemek için      : (2)");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        break;
                    }
                    else if (n == 2)
                        goto deletenumber;
                }
            }

 
        }
    }
}
