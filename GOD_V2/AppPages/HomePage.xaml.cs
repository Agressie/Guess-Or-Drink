using GOD_V2.MVVM;
using GOD_V2.AppPages;
using GOD_V2.AppPages.AccountPages;
using GOD_V2.AppPages.MenuPages;

namespace GOD_V2.AppPages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public void OnSeeAccountClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountPage());
        }
        public void OnCreategameClicked(object sender, EventArgs e)
        {
            Game.CreateGame();
            Navigation.PushAsync(new CategoryPage());
        }
    }
}
