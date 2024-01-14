using GOD_V2.MVVM;
using GOD_V2.MVVM.ViewModels;

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
}