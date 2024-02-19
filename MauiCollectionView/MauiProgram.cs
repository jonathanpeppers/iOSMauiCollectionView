using MauiCollectionView.ViewModels;
using MauiCollectionView.Views;
using Microsoft.Extensions.Logging;

namespace MauiCollectionView
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MyPage>();
            builder.Services.AddTransient<MyViewModel>();

            return builder.Build();
        }
    }
}
