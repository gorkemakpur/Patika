using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { ID = 1, UserName = "aziz", Password = "123" ,IsDelete = false},
                new User { ID = 2, UserName = "gorkem", Password = "456" ,  IsDelete = false},
                new User { ID = 3, UserName = "akpur", Password = "789" ,IsDelete = false}

            };

        }
        public void Add(User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public User GetByUser(string userName)
        {
            return _users.Find(x => x.UserName == userName);
        }

    }
}
