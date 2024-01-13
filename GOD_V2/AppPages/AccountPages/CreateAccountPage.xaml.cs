using GOD_V2.MVVM;

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