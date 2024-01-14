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
        Category category = VM_Category.GetCategory(0);
        // Color: LightGoldenrodYellow
    }   
    public void Ontherocksclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        VM_Category.GetCategory(1);
        // Color: Orange
    }
    public void Lastcallclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        VM_Category.GetCategory(2);
        // Color: OrangeRed
    }
    public void Spicyclicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamemodePage());
        VM_Category.GetCategory(3);
        // Color: Crimson
    }
}