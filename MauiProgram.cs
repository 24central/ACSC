using ACSC.Services;
using ACSC.viewmodel;
using CommunityToolkit.Maui;

namespace ACSC;

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

		builder.Services.AddSingleton<IntStudentService, StudentService>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<Mainviewmodel>();

		builder.Services.AddTransient<Afterlogin>();
		builder.Services.AddTransient<Afterlogviewmodel>();

        builder.Services.AddTransient<AfterLoginUpdate>();
        builder.Services.AddTransient<AfterLoginUpdateVm>();
        return builder.Build();
	}
}
