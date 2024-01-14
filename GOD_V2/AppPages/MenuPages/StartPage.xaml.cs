namespace GOD_V2.AppPages.MenuPages;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    private void OnStartclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
    }
}