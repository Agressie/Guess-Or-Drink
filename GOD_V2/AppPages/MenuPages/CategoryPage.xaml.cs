namespace GOD_V2.AppPages.MenuPages;

public partial class CategoryPage : ContentPage
{
    public CategoryPage()
    {
        InitializeComponent();
    }

    // The gamemode that is chosen gives a color that is set to diffrent elements throughout the entiry game.
    public void Happyhourclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        // Color: LightGoldenrodYellow
    }   
    public void Ontherocksclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        // Color: Orange
    }
    public void Lastcallclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        // Color: OrangeRed
    }
    public void Spicyclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        // Color: Crimson
    }
}