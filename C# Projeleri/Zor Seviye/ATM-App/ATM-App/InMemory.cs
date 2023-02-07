using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class InMemory
    {
        List<User> users;
        public InMemory()
        {
            users = new List<User>
            {
                new User { ID = 1, CardNumber = "000", Password = "123" , FirstName = "Ayşe" , LastName = "Hayati" , Balance = 180},
                new User { ID = 1, CardNumber = "111", Password = "123" , FirstName = "Fatma" , LastName = "Dinar" , Balance = 75 },
                new User { ID = 1, CardNumber = "222", Password = "123" , FirstName = "Hayriye" , LastName = "Yılmaz", Balance = 90 },
          
            };

        }
        public User GetByUser(string cardNumber)
        {
            return users.Find(x => x.CardNumber == cardNumber);
        }
        public void BalanceUpdate(string cardNumber, int balance)
        {
            User user = users.Find(x => x.CardNumber == cardNumber);
            user.Balance = balance;

        }
    }
}
