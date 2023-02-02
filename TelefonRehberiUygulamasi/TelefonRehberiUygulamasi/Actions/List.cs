using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiUygulamasi.Data;

namespace TelefonRehberiUygulamasi.Actions
{
    public class List
    {
        public void ListPhoneBook()
        {
            foreach (var item in PhoneBookData.PhoneList)
            {
                Console.WriteLine("İsim :" + item.FirstName);
                Console.WriteLine("Soyisim :" + item.LastName);
                Console.WriteLine("Numara :" + item.PhoneNumber);
                Console.WriteLine("  - ");


            }
        }
    }
}
