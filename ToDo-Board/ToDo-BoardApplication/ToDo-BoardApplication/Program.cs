using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_BoardApplication.Actions;
using ToDo_BoardApplication.Data;

namespace ToDo_BoardApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database datas = new Database();
        mainMenu:
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("  *******************************************");
            Console.WriteLine("  (1) Board Listelemek");
            Console.WriteLine("  (2) Board'a Kart Eklemek");
            Console.WriteLine("  (3) Board'dan Kart Silmek");
            Console.WriteLine("  (4) Kart Taşımak");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    List list = new List();
                    list.ListCard();
                    goto mainMenu;

                case 2:
                    Add add = new Add();
                    add.AddCard();
                    goto mainMenu;

                case 3:
                    Delete delete = new Delete();
                    delete.DeleteCard();
                    goto mainMenu;

                case 4:
                    Move move = new Move();
                    move.MoveCard();
                    goto mainMenu;

                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    goto mainMenu;
            }
        }
    }
}
