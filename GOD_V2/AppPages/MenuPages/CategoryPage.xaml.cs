using GOD_V2.MVVM;
using GOD_V2.MVVM.Models;
using GOD_V2.MVVM.ViewModels;

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
        SetGameCategory(0);
    }   
    public void Ontherocksclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        SetGameCategory(1);
    }
    public void Lastcallclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        SetGameCategory(2);
    }
    public void Spicyclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        SetGameCategory(3);
    }
    private void SetGameCategory(int cat)
    {
        Category category = VM_Category.GetCategory(cat);
        Game.SetCategory(category);
    }
}