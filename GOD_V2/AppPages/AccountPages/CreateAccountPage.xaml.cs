using GOD_V2.MVVM;
using GOD_V2.MVVM.ViewModels;
using Plugin.LocalNotification;

namespace GOD_V2.AppPages.AccountPages;

public partial class CreateAccountPage : ContentPage
{
    public CreateAccountPage()
    {
        InitializeComponent();
    }
    public void Onaccountcreateclicked(object sender, EventArgs e)
    {
        var UsernameEmpty = string.IsNullOrEmpty(EntryUsername.Text);
        var PasswordEmpty = string.IsNullOrEmpty(EntryPassword.Text);
        var ConfirmPasswordEmpty = string.IsNullOrEmpty(EntryConfirmPassword.Text);

        if (UsernameEmpty)
            EntryUsername.Placeholder = "Vul iets in!";
        else if (PasswordEmpty)
            EntryPassword.Placeholder = "Vul iets in!";
        else if (ConfirmPasswordEmpty)
            EntryConfirmPassword.Placeholder = "Vul iets in!";
        else
        {
            if (VM_User.Checkusername(EntryUsername.Text) == false)
            {
                if (EntryPassword.Text == EntryConfirmPassword.Text)
                {
                    VM_User.CreateNewUser(EntryUsername.Text, EntryPassword.Text);
                    Navigation.PushAsync(new HomePage());
                }
                else
                    Invalid.Text = "Passwords don't match";
            }
            else
                Invalid.Text = "Username already exists";
        }
    }

    public void Accountnotification(string username)
    {
        var rq = new NotificationRequest
        {
            NotificationId = 1000,
            Title = "Welcome to Guess Or Drink",
            Subtitle = "Account created with GOD",
            Description = "Thank you for creating an account with us. Have fun and remember don't go over your limits!",
            BadgeNumber = 42,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(30),
                NotifyRepeatInterval = TimeSpan.FromSeconds(30),
            }
        };
        LocalNotificationCenter.Current.Show(rq);
    }
}