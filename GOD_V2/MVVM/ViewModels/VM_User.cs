using GOD_V2.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;

namespace GOD_V2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VM_User
    {
        public static User? currentuser { get; set; }
        public static List<User>? users = new List<User>();

        public static void CreateNewUser(string username, string password)
        {
            Refresh();
            User user = new User();
            user.Name = username;
            user.Password = password;
            App.UserRepo.SaveEntity(user);
            Console.WriteLine(App.UserRepo.statusMessage);

        }

        private static void Refresh()
        {
            users = App.UserRepo.GetEntities();
        }

        public static bool LoginCheck(string username, string password)
        {
            Refresh();
            bool result = false;
            foreach (var user in users)
            {
                if (user.Name == username)
                    if (user.Password == password)
                    {  
                        result = true;
                        currentuser = user;
                    }
            }
            return result;
        }

        public static bool Checkusername(string Username)
        {
            Refresh();
            bool result = true;
            foreach (var user in users)
            {
                if (user.Name == Username)
                    result = true;
                else
                    result = false;
            }
            return result;
        }

        public void setcurrentuser(User user)
        {
            currentuser = user;
        }
    }
}
