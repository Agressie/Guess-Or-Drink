using GOD_V2.API;

namespace GOD_V2.AppPages.AccountPages;

public partial class AccountPage : ContentPage
{
    public AccountPage()
    {
        InitializeComponent();

        OnCreate();

    }

    private async void OnCreate()
    {
        MemeImage.Source = ImageSource.FromUri(new Uri(await ServiceLocator.memeService.GetMeme()));
    }

}