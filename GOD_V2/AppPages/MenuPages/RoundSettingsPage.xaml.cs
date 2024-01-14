using GOD_V2.MVVM;
using GOD_V2.MVVM.ViewModels;
using GOD_V2.AppPages.MenuPages;
using GOD_V2.AppPages.GamePages;
using Microsoft.Maui.Graphics.Converters;

namespace GOD_V2.AppPages.MenuPages;

public partial class RoundSettingsPage : ContentPage
{
	public RoundSettingsPage()
	{
		InitializeComponent();
        InitPage();
    }
    public void InitPage()
    {
        var game = Game.GetGame();
        var gamecolor = game.gamecategory.color;
        ColorTypeConverter converter = new ColorTypeConverter();
        Color color = (Color)(converter.ConvertFromString(gamecolor));
        BtnStart.BackgroundColor = color;
    }
    public void Rondesettingclicked(object sender, EventArgs a)
    {
        Navigation.PushAsync(new SettingsPage());
    }
    public void StartClicked(object sender, EventArgs a)
    {
        Navigation.PushAsync(new PreGamePage());
    }
}