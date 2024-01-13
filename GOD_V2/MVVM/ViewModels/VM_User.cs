using GOD_V2.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;

namespace GOD_V2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VM_User
    {
        public User? currentuser { get; set; }
        public static List<User>? users { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }


        public VM_User()
        {
            Refresh();
            AddOrUpdateCommand = new Command(async () =>
            {
                App.UserRepo.SaveEntity(currentuser);
                Console.WriteLine(App.UserRepo.statusMessage);
                Refresh();
            });

            DeleteCommand = new Command(async () =>
            {
                App.UserRepo.DeleteEntity(currentuser);
                Console.WriteLine(App.UserRepo.statusMessage);
                Refresh();
            });
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
                if (user.name == username)
                    if (user.Password == password)
                        result = true;
            }
            return result;
        }
    }
}
