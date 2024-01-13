using GOD_V2.MVVM;
using GOD_V2.MVVM.ViewModels;

namespace GOD_V2.AppPages.AccountPages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private void Onloginclicked(object sender, EventArgs e)
    {
        var UsernameEmpty = string.IsNullOrEmpty(EntryUsername.Text);
        var PasswordEmpty = string.IsNullOrEmpty(EntryPassword.Text);

        if (UsernameEmpty)
            EntryUsername.Placeholder = "Vul iets in!";
        else if (PasswordEmpty)
            EntryPassword.Placeholder = "Vul iets in!";
        else
        {
            if (VM_User.LoginCheck(EntryUsername.Text, EntryPassword.Text) == true)
                Navigation.PushAsync(new HomePage());
            else
                Invalid.IsVisible = true;
        }
    }
    private void OnCreateaccountClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreateAccountPage());
    }
}