using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberiUygulamasi.Data;

namespace TelefonRehberiUygulamasi.Actions
{
    public class Add
    {
        public void AddNumber()
        {
            Console.WriteLine(" Lütfen isim giriniz             : ");
            string name = Console.ReadLine();
            Console.WriteLine(" Lütfen soyisim giriniz          :");
            string lastName = Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz :");
            string number = Console.ReadLine();

            Person person = new Person();
            person.FirstName = name;
            person.LastName = lastName;
            person.PhoneNumber = number;

            PhoneBookData.PhoneList.Add(person);
            Console.WriteLine("{0} {1} {2}", name, lastName, number);

            List listedPersons = new List();
            listedPersons.ListPhoneBook();
        }
    }
}
