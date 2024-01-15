using GOD_V2.MVVM;
using Microsoft.Maui.Graphics.Converters;

namespace GOD_V2.AppPages.MenuPages;

public partial class SettingsPage : ContentPage
{
    private int rounds = 5;
    private List<string> teams = new List<string>();
	public SettingsPage()
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
        btnsave.BackgroundColor = color;
    }

    public void OnAddTeamClicked(object sender, EventArgs e) 
    {
        var TeamEmpty = string.IsNullOrEmpty(team.Text);

        if (TeamEmpty == true) 
        {
            // Code that show please add a team name
        }
        else
        {
            teams.Add(team.Text);
        }
    }
    public void OnSaveClicked(object sender, EventArgs e)
    {
        // Code that adds a team to the game teams list and sets the rounds for that game. 
    }
}