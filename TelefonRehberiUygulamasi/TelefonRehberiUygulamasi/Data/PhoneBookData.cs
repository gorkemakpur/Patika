using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulamasi.Data
{
    public class PhoneBookData
    {
        private static List<Person> _phoneList;

        static PhoneBookData()
        {
            _phoneList = new List<Person>()
            {
                new Person{FirstName= "Aziz", LastName="Görkem", PhoneNumber= "1234567890" },
                new Person{FirstName= "Görkem", LastName="Akpur", PhoneNumber= "1111111111" },
                new Person{FirstName= "Ahmet", LastName="Kural", PhoneNumber= "2222222222" },
                new Person{FirstName= "Çağlar", LastName="Çorumlu", PhoneNumber= "3333333333" },
                new Person{FirstName= "Cem", LastName="Yılmaz", PhoneNumber= "4444444444" },
            };
        }
        public static List<Person> PhoneList
        {
            get { return _phoneList; }
        }
    }
}
