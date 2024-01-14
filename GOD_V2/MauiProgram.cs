using GOD_V2.MVVM.Models;
using GOD_V2.MVVM.ViewModels;
using GOD_V2.SQLite;
using Microsoft.Extensions.Logging;

namespace GOD_V2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<BaseRepo<Category>>();
            builder.Services.AddSingleton<BaseRepo<Charade>>();
            builder.Services.AddSingleton<BaseRepo<User>>();
            VM_Category.initCategoryDB();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
