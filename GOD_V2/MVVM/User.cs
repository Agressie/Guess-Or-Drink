using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.MVVM
{
    internal class User
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private static List<User> Users = new();

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public static void Createusers()
        {
            User Noah = new User("Noah", "Pass");
            User Test = new User("Test", "Test");
            Users.Add(Noah);
            Users.Add(Test);
        }

        public static void CreateNewUser(string username, string password)
        {
            User user = new User(username, password);
            Users.Add(user);
        }
        public static bool LoginCheck(string username, string password)
        {
            bool result = false;
            foreach (var user in Users)
            {
                if (user.Username == username)
                    if (user.Password == password)
                        result = true;
            }
            return result;
        }
        public static bool Checkusername(string Username)
        {
            foreach (var user in Users)
            {
                if (user.Username == Username)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
