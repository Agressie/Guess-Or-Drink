using GOD_V2.MVVM;
using GOD_V2.AppPages.MenuPages;
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
            if (User.Checkusername(EntryUsername.Text))
            {
                if (EntryPassword.Text == EntryConfirmPassword.Text)
                {
                    User.CreateNewUser(EntryUsername.Text, EntryPassword.Text);
                    PushNotify(EntryUsername.Text);
                    Navigation.PushAsync(new HomePage());
                }
                else
                    Invalid.Text = "Passwords don't match";
            }
            else
                Invalid.Text = "Username already exists";
        }
    }
    private void PushNotify(string username)
    {
        var request = new NotificationRequest
        {
            NotificationId=1000,
            Title="Welcome to Guess Or Drink",
            Subtitle="Account created with GOD",
            Description="Thankyou for creating an account with us, and remember don't go over your limits!",
            BadgeNumber=42,
            Schedule=new NotificationRequestSchedule
            {
                NotifyTime=DateTime.Now.AddSeconds(5),
                NotifyRepeatInterval=TimeSpan.FromSeconds(5),
            }
        };
        LocalNotificationCenter.Current.Show(request);
    }
}