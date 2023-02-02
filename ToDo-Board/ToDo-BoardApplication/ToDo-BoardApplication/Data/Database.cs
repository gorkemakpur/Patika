using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_BoardApplication.Data
{
        public class Database
        {
            private static List<Card> _defaultCard;
            private static List<Person> _person;
            static Database()
            {
                _person = new List<Person>()
            {
                new Person{Id=1,Name="Ahmet Aslan"},
                new Person{Id=2,Name="Kaan Tangöze"},
                new Person{Id=3,Name="Oğuzhan Koç"},
            };

                _defaultCard = new List<Card>()
            {
                new Card{Title="Kurs",Content="İngilizce Kursuna Gidilecek",Member="Oğuzhan Koç",Size="L",Line="TODO"},
                new Card{Title="Ders",Content="Yazılım kursuna devam ediliyor",Member="Kaan Tangöze",Size="S",Line="INPROGRESS"},
                new Card{Title="Oku",Content="Yeni alınan kitap okundu",Member="Ahmet Aslan",Size="XS",Line="DONE"},
            };

            }

            public static List<Card> defaultCard => _defaultCard;
            public static List<Person> defaultPersons => _person;


        }
    }
