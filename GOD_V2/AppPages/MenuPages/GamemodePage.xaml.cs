namespace GOD_V2.AppPages.MenuPages;

public partial class GamemodePage : ContentPage
{
    public GamemodePage()
    {
        InitializeComponent();
    }
    public void Guessclicked(object sender, EventArgs a)
    {
        Navigation.PushAsync(new AppPages.MenuPages.RoundSettingsPage());
    }
    public void Portrayclicked(object sender, EventArgs a)
    {
        Navigation.PushAsync(new AppPages.MenuPages.RoundSettingsPage());
    }
}