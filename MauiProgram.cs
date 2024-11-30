using CommunityToolkit.Maui;
using Serilog;
using System.Diagnostics;
using test24240.ViewModels;

namespace test24240
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
                });

            // Serilog logging configuration
            builder.Logging
                .AddSerilog(new LoggerConfiguration()
                .WriteTo.Debug(
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Verbose)
                .WriteTo.File(
                    Constants.LogFileFullPath,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 7,
                    restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Verbose)
                .MinimumLevel.Verbose()
                .CreateLogger());

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>();

            Serilog.Debugging.SelfLog.Enable(msg => Debug.WriteLine(msg));

            return builder.Build();
        }
    }
}
