using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("ArsenalSC-Regular.ttf", "ArsenalSC-Regular");
                    fonts.AddFont("BebasNeue-Regular.ttf", "BebasNeue-Regular");


                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");


                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");

                    fonts.AddFont("supercharge3d.ttf", "supercharge3d");
                    fonts.AddFont("The-Wanters.ttf", "TheWanters");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
