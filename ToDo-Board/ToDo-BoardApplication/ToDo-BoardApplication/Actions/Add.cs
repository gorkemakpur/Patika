using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_BoardApplication.Data;

namespace ToDo_BoardApplication.Actions
{
    public class Add
    {
        public void AddCard()
        {
            Card card = new Card();
            Console.WriteLine("Başlık Giriniz                                       :");
            card.Title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                       :");
            card.Content = Console.ReadLine();
        size:
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)       :");
            int entry = int.Parse(Console.ReadLine());
            Size size = (Size)entry;

            switch (size)
            {
                case Size.XS:
                    card.Size = "XS";
                    break;

                case Size.S:
                    card.Size = "S";
                    break;

                case Size.M:
                    card.Size = "M";
                    break;

                case Size.L:
                    card.Size = "L";
                    break;

                case Size.XL:
                    card.Size = "XL";
                    break;

                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız.");
                    goto size;
            }
        person:
            Console.WriteLine("Kişi Seçiniz                                         :");
            string idEntry = Console.ReadLine();
            int personId;
            if (int.TryParse(idEntry, out personId) && 0 < personId && personId <= Database.defaultPersons.Count)
            {
                card.Member = Database.defaultPersons.FirstOrDefault(x => x.Id == personId).Name;
                Database.defaultCard.Add(card);
                Console.WriteLine("Kart başarıyla eklendi!");
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen ID giriniz.");
                goto person;
            }


        }

        enum Size
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
    }
}
