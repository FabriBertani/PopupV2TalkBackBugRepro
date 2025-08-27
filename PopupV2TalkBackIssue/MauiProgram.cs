using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PopupV2TalkBackIssue.Popups;
using PopupV2TalkBackIssue.ViewModels;
using PopupV2TalkBackIssue.Views;

namespace PopupV2TalkBackIssue;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit(options =>
			{
				options.SetShouldSuppressExceptionsInBehaviors(true);
				options.SetShouldSuppressExceptionsInConverters(true);
				options.SetShouldSuppressExceptionsInAnimations(true);
			})
			.RegisterViewsAndViewModels()
			.RegisterPopups()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder builder)
	{
		builder.Services.AddTransient<MainPage, MainViewModel>();

		return builder;
	}

	static MauiAppBuilder RegisterPopups(this MauiAppBuilder builder)
	{
		builder.Services.AddTransient<SimplePopup>();
		builder.Services.AddTransient<ComplexPopup>();

		return builder;
	}
}
