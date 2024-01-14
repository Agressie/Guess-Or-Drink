using GOD_V2.MVVM;
namespace GOD_V2.AppPages.MenuPages;

public partial class GamemodePage : ContentPage
{
    public GamemodePage()
    {
        InitializeComponent();
    }
    //true = Guess
    //False = Portray
    public void Guessclicked(object sender, EventArgs a)
    {
        Game.SetGamemode(true);
        Navigation.PushAsync(new AppPages.MenuPages.RoundSettingsPage());
        
    }
    public void Portrayclicked(object sender, EventArgs a)
    {
        Game.SetGamemode(false);
        Navigation.PushAsync(new AppPages.MenuPages.RoundSettingsPage());
    }
}