using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using UpworkDemo.Pages;

namespace UpworkDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Awesome-Regular.otf", "AwesomeRegular");
                });

            builder.Services.AddSingleton<WelcomePage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<Dashboard>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
