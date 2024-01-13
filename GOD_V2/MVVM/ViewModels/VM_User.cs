﻿using GOD_V2.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;

namespace GOD_V2.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VM_User
    {
        public User? currentuser { get; set; }
        public static List<User>? users { get; set; }
        public static void CreateNewUser(string username, string password)
        {
            User user = new User(username, password);
            App.UserRepo.SaveEntity(user);
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

        public static bool Checkusername(string Username)
        {
            foreach (var user in users)
            {
                if (user.name == Username)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
