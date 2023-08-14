using Microsoft.Extensions.Logging;

namespace CoffeeAppDemo;
/*
 .icon-left-open:before { content: '\e800'; } 
.icon-smile:before { content: '\f118'; }  
 */

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
                fonts.AddFont("Rubik-Light.ttf", "RubikLight");
                fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
                fonts.AddFont("fontello.ttf", "Icons");
                
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}