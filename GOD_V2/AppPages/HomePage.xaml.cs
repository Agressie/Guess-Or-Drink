using GOD_V2.MVVM;
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

        public void OnAccountClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountPage());
        }
        public void OnCreateGameClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategoryPage());
        }
    }

}
