using GOD_V2.SQLite;
using GOD_V2.MVVM.Models;

namespace GOD_V2
{
    public partial class App : Application
    {
        public static BaseRepo<Category>? CategoryRepo { get; private set; }

        public static BaseRepo<Charade>? CharadeRepo { get; private set; }
        public App(BaseRepo<Category>? categoryRepo, BaseRepo<Charade>? charadeRepo)
        {
            InitializeComponent();

            CharadeRepo = charadeRepo;
            CategoryRepo = categoryRepo;
            MainPage = new AppShell();
        }
    }
}
