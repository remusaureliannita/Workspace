using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{

    class DataBase
    {
        private static List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void AddUser(int id, String name)
        {
            User user = new User(id, name);
            users.Add(user);
        }

        public User GetUser(int id)
        {
            User user = new User();
            foreach (User index in users)
            {
                if (id == index.id)
                {
                    user = index;
                }
            }

            return user;
        }
        public void RemoveUser(int id)
        {
            User user = GetUser(id);
            users.Remove(user);
        }

        public void Display()
        {
            foreach (User user in users)
            {
                Console.WriteLine("ID: {0}     Name: {1}", user.id, user.name);
            }
        }
    }
}
